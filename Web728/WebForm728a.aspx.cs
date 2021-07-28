using System;
using System.Web;

namespace Web728
{
    public partial class WebForm728a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpContext context = HttpContext.Current;
            // use this.Request.QueryString or context.Request.QueryString
            ProcessRequest(context);
        }

        private void ProcessRequest(HttpContext context)
        {
            string get_id = context.Request.QueryString["id"];
            string[] get_name = context.Request.QueryString.GetValues("name");

            string post_id = context.Request.Form["id"];
            string[] post_name = context.Request.Form.GetValues("name");
            string methodType = context.Request.HttpMethod;

            string userAgent = context.Request.UserAgent;
            string url = context.Request.Url.ToString();
            string header = context.Request.Headers["Accept"];

            string output =
                $@"
                    CurrentMethod:{methodType}<br/>
                    Get-ID:{get_id} <br/>
                    get_name:{get_name }<br/>
                    post_id:{post_id}<br/>
                    post_name: {post_name}<br/>
                    userAgent:{userAgent}<br/>
                    url;{url}:{url}<br/> 
                    heder:{header} <br/>
                   ";
            Response.Write(output);
        }


    }
}