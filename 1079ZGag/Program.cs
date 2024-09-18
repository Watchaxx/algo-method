using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string[] w = ReadLine().Split( ' ' ).ToArray();

        if( string.Concat( w ).Length < 26 ) {
            WriteLine( -1 );
            return;
        }

        int o = int.MaxValue;

        for( int i = 1; i < 1 << n; i++ ) {
            int p = 0;
            int x = 0;

            foreach( int j in Enumerable.Range( 0, n ) ) {
                if( ( i & ( 1 << j ) ) != 0 ) {
                    x++;
                    foreach( char c in w[j] ) {
                        p |= 1 << ( c - 'a' );
                    }
                }
            }
            if( p == ( 1 << 26 ) - 1 && x < o ) {
                o = x;
            }
        }
        WriteLine( o != int.MaxValue ? o : -1 );
        return;
    }
}
