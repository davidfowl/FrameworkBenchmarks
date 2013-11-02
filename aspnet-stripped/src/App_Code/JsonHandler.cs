using System.IO;
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

        var jsonTextWriter = new JsonTextWriter(context.Response.Output);
        jsonTextWriter.WriteStartObject();
        jsonTextWriter.WritePropertyName("message");
        jsonTextWriter.WriteValue("Hello, world");
        jsonTextWriter.WriteEndObject();
    }
}