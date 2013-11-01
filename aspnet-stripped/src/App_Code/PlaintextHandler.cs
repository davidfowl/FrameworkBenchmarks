using System.Web;

public class PlaintextHandler : IHttpHandler
{
    bool IHttpHandler.IsReusable
    {
        get { return true; }
    }

    void IHttpHandler.ProcessRequest(HttpContext context)
    {
        HttpResponse response = context.Response;
        response.ContentType = "text/plain";
        response.Write("Hello, World!");
    }
}