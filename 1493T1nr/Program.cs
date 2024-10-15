using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] d = Enumerable.Repeat( int.MaxValue / 2, nm[0] ).ToArray();
        int[] f = Enumerable.Repeat( -1, nm[0] ).ToArray();
        int[][] uvw = new int[nm[1]][];
        var o = new System.Collections.Generic.List<int>( nm[0] ) { nm[0] - 1 };

        d[0] = 0;
        foreach( int i in Enumerable.Range( 0, nm[1] ) ) {
            uvw[i] = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        }
        foreach( int i in Enumerable.Range( 0, nm[0] ) ) {
            bool b = true;

            foreach( int[] j in uvw ) {
                int t = d[j[0]] + j[2];

                if( t < d[j[1]] ) {
                    b = false;
                    d[j[1]] = t;
                    f[j[1]] = j[0];
                }
            }
            if( b == true ) {
                break;
            }
        }
        while( true ) {
            o.Add( f[o.Last()] );
            if( f[o.Last()] == -1 ) {
                break;
            }
        }
        o.Reverse();
        WriteLine( $"{o.Count}{System.Environment.NewLine}{string.Join( " ", o )}" );
        return;
    }
}
