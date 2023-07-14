using System.Text;

class App
{
    static WordFilter WFilter = new WordFilter();   
    static NumberFilter NFilter = new NumberFilter();   
    static void Main(string[] args)
    {
        string test = WFilter.ClString("K y l e");
        string test2 = NFilter.ClString("");

        Console.WriteLine();
    }
}