using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nmst = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] d = Enumerable.Repeat( -1, nmst[0] ).ToArray();
        var l = new List<int>[nmst[0]];
        var q = new Queue<int>( nmst[0] );

        foreach( int i in Enumerable.Range( 0, nmst[0] ) ) {
            l[i] = new List<int>();
        }
        foreach( int _ in Enumerable.Range( 0, nmst[1] ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            l[t[0]].Add( t[1] );
        }
        d[nmst[2]] = 0;
        q.Enqueue( nmst[2] );
        while( 0 < q.Count ) {
            int i = q.Dequeue();

            foreach( int j in l[i].Where( x => d[x] == -1 ) ) {
                d[j] = d[i] + 1;
                q.Enqueue( j );
            }
        }
        WriteLine( d[nmst[3]] != -1 ? "Yes" : "No" );
        return;
    }
}
