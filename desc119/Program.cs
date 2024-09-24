using static System.Console;

internal class Program
{
    static void Main()
    {
        long n = long.Parse( ReadLine() );
        var l = new System.Collections.Generic.List<long>();

        for( long i = 2; i * i <= n; i++ ) {
            if( n % i != 0 ) {
                continue;
            }

            int e = 0;

            while( n % i == 0 ) {
                e++;
                n /= i;
            }
            l.AddRange( System.Linq.Enumerable.Repeat( i, e ) );
        }
        if( n != 1 ) {
            l.Add( n );
        }
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
