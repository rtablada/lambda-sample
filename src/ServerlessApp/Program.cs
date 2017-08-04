using ServerlessApp;

public class Program
{
    public static void Main()
    {
        var fcn = new FooServiceEntry();
        fcn.Run(new Request { Key1 = "val1" } );
    }
}