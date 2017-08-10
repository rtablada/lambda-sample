public interface IFooService : IExecutable<Request, Response>
{ }

public class FooService : IFooService
{
    private readonly IRequestWriter _writer;

    public FooService(IRequestWriter writer)
    {
        _writer = writer;
    }

    public Response Execute(Request request)
    {
        _writer.Write(request);
        return new Response("Success", request);
    }
}
