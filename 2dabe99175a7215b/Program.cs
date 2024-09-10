using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string x = ReadLine();

        WriteLine( Rev( x, n - 1 ) );
        return;
    }

    static string Rev( string s, int i )
    {
        return i == 0 ? $"{s[0]}" : Rev( s, i - 1 ) + s[i] + Rev( s, i - 1 );
    }
}
