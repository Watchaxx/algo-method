using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] am = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        WriteLine( ( am[0] & am[1] ) == am[1] ? "Yes" : "No" );
        return;
    }
}
