using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int o = 0;
        long[] ab = ReadLine().Split( ' ' ).Select( long.Parse ).ToArray();
        long n = System.Math.Abs( ab[0] - ab[1] );

        for( long i = 1; i * i <= n; i++ ) {
            if( n % i != 0 ) {
                continue;
            }
            o++;
            if( n / i != i ) {
                o++;
            }
        }
        WriteLine( o );
        return;
    }
}
