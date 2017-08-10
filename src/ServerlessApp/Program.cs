using ServerlessApp;

public class Program
{
    public static void Main()
    {
        var fcn = new JsonReaderServiceEntry();
        fcn.Run(new Request { Key1 = "val1" } );
    }
}
