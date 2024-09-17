using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        const int lim = 500001;
        int m = 0;
        int n = int.Parse( ReadLine() );
        int[] aa = Enumerable.Repeat( 0, lim ).ToArray();

        foreach( int i in ReadLine().Split( ' ' ).Select( int.Parse ) ) {
            aa[i]++;
            m = System.Math.Max( m, i );
        }

        int q = int.Parse( ReadLine() );
        int[] am = Enumerable.Repeat( -1, lim ).ToArray();
        int[] an = Enumerable.Repeat( 0, q ).ToArray();

        foreach( int i in Enumerable.Range( 0, q ) ) {
            int c = 0;
            int t = int.Parse( ReadLine() );

            if( am[t] == -1 ) {
                if( t == 1 ) {
                    c = n;
                } else {
                    for( int j = t; j < m + 1; j += t ) {
                        c += aa[j];
                    }
                }
                am[t] = c;
            }
            an[i] = am[t];
        }
        WriteLine( string.Join( "\n", an ) );
        return;
    }
}
