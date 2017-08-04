public class Request
{
    public string Key1 { get; set; }
    public string Key2 { get; set; }
    public string Key3 { get; set; }

    public Request()
    { }

    public Request(string key1, string key2, string key3)
    {
        Key1 = key1;
        Key2 = key2;
        Key3 = key3;
    }
}