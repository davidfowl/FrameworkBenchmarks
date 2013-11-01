using System.Web;
using Newtonsoft.Json;

public class JsonHandler : IHttpHandler
{
    bool IHttpHandler.IsReusable
    {
        get { return true; }
    }

    void IHttpHandler.ProcessRequest(HttpContext context)
    {
        HttpResponse response = context.Response;
        response.ContentType = "application/json";
        response.Write(JsonConvert.SerializeObject(new { message = "Hello, World!" }));
    }
}