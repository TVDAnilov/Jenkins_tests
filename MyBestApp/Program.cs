
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        var obj = new { Name = "John", Age = 30 };
        string json = JsonConvert.SerializeObject(obj);
        Console.WriteLine(json);
    }
}