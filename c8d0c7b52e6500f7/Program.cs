using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        char c = char.Parse( ReadLine().ToLower() );
        string s = ReadLine().ToLower();
        WriteLine( s.Count( x => x == c ) );
        return;
    }
}
