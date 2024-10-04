using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] w  = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] c  = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        bool[][] p = new bool[257][];
        var d = new Dictionary<int, List<int>>( 256 );

        foreach( int i in Enumerable.Range( 0, 257 ) ) {
            p[i] = Enumerable.Repeat( false, nm[1] + 1 ).ToArray();
        }
        p[0][0] = true;
        foreach( int i in Enumerable.Range( 0, nm[0] ) ) {
            if( d.ContainsKey( c[i] ) != true ) {
                d[c[i]] = new List<int>( nm[0] ) { w[i] };
            } else {
                d[c[i]].Add( w[i] );
            }
        }
        foreach( int i in Enumerable.Range( 0, 256 ) ) {
            System.Array.ConstrainedCopy( p[i], 0, p[i + 1], 0, nm[1] + 1 );
            if( d.ContainsKey( i ) != true ) {
                continue;
            }
            foreach( int j in d[i] ) {
                foreach( int k in Enumerable.Range( 0, nm[1] + 1 ) ) {
                    if( j + k <= nm[1] && p[i][k] == true ) {
                        p[i + 1][j + k] = true;
                    }
                }
            }
        }
        WriteLine( p[256][nm[1]] ? "Yes" : "No" );
        return;
    }
}
