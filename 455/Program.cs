using static System.Console;

internal class Program
{
    static void Main()
    {
        long a = long.Parse( ReadLine() );
        long o = 1;
        var l = new System.Collections.Generic.List<long[]>();

        for( long i = 2; i * i <= a; i++ ) {
            if( a % i != 0 ) {
                continue;
            }

            int e = 0;

            while( a % i == 0 ) {
                e++;
                a /= i;
            }
            l.Add( new long[] { i, e } );
        }
        if( 1 < a ) {
            l.Add( new long[] { a, 1 } );
        }
        foreach( long[] p in l ) {
            if( p[1] % 2 != 0 ) {
                o *= p[0];
            }
        }
        WriteLine( o );
        return;
    }
}
