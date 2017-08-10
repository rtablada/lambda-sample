using System;
using System.IO;

public interface IJsonReaderService : IExecutable<Request, Response>
{ }

public class JsonReaderService : IJsonReaderService
{
    private readonly IRequestWriter _writer;

    public JsonReaderService()
    {
    }

  public Response Execute(Request request)
  {
    string path = Directory.GetCurrentDirectory();

    Console.WriteLine(path);

    return new Response("Success", request);
  }
}
