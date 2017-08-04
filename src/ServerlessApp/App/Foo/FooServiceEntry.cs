using Amazon.Lambda.Core;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace ServerlessApp
{
    public class FooServiceEntry : EntryPoint<FooService, Request, Response> { }
}
