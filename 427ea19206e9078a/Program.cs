using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] ab = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] xy = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

        if( ab[0] < xy[0] ) {
            WriteLine( "No" );
            return;
        }
        WriteLine( xy[1] <= ab.Sum() ? "Yes" : "No" );
        return;
    }
}
