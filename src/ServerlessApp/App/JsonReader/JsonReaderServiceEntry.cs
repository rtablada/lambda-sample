using Amazon.Lambda.Core;

// [assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace ServerlessApp
{
    public class JsonReaderServiceEntry : EntryPoint<JsonReaderService, Request, Response> { }
}
