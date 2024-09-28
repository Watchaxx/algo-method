using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        long o = 1;
        long[] nm = ReadLine().Split( ' ' ).Select( long.Parse ).ToArray();

        foreach( int l in Func( nm[1] ) ) {
            o *= l / nm[0] + 1;
        }
        WriteLine( o );
        return;
    }

    static int[] Func( long n )
    {
        var l = new System.Collections.Generic.List<int>();

        for( long i = 2; i * i <= n; i++ ) {
            if( n % i != 0 ) {
                continue;
            }

            int e = 0;

            while( n % i == 0 ) {
                e++;
                n /= i;
            }
            l.Add( e );
        }
        if( n != 1 ) {
            l.Add( 1 );
        }
        return l.ToArray();
    }
}
