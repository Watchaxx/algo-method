using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        long n = long.Parse( ReadLine() );
        var l = new System.Collections.Generic.List<long>();

        for( long i = 1; i * i <= n; i++ ) {
            if( n % i != 0 ) {
                continue;
            }
            l.Add( i );
            if( n / i != i ) {
                l.Add( n / i );
            }
        }
        WriteLine( string.Join( " ", l.OrderBy( x => x ) ) );
        return;
    }
}
