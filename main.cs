using System;
using System.Net;
using System.Web.UI;
using System.IO;

namespace CSharp
{
  public partial class _Default : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string strurltest = String.Format("https://jsonplaceholder.typicode.com/posts");
      WebRequest requestObjGet = WebRequest.Create(strurltest);
      requestObjGet.Method = "GET"; 
      HttpWebResponse responseObjGet = null;
      responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();

      string strresulttest = null;
      using (Stream stream = responseObjGet.GetResponseStream())
      {
        StreamReader sr = new StreamReader(stream);
        strresulttest = sr.ReadToEnd();
        sr.Close();
      }
    }
  }
}