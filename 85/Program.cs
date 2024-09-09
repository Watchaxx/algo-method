using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] ab = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

        if( ab[0] == ab[1] ) {
            WriteLine( "No" );
            return;
        }
        WriteLine( Ya( ab[0] ) == Ya( ab[1] ) ? "Yes" : "No" );
        return;
    }

    static int Ya( int x )
    {
        int y = 0;

        foreach( var i in Enumerable.Range( 2, x - 1 ).Where( i => x % i == 0 ) ) {
            y += i;
        }
        return y;
    }
}
