using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] d = Enumerable.Repeat( int.MaxValue / 2, nm[0] ).ToArray();
        bool[] b = Enumerable.Repeat( false, nm[0] ).ToArray();
        var l = new List<int[]>[nm[0]];
        var q = new Queue<int[]>( nm[0] );

        d[0] = 0;
        q.Enqueue( new int[] { 0, 0 } );
        foreach( int i in Enumerable.Range( 0, nm[0] ) ) {
            l[i] = new List<int[]>();
        }
        foreach( int i in Enumerable.Range( 0, nm[1] ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            l[t[0]].Add( new int[] { t[1], t[2] } );
        }
        while( 0 < q.Count ) {
            int[] dq = q.Dequeue();

            if( b[dq[1]] == true ) {
                continue;
            }
            foreach( int[] i in l[dq[1]].Where( i => dq[0] + i[1] < d[i[0]] ) ) {
                d[i[0]] = dq[0] + i[1];
                q.Enqueue( new int[] { d[i[0]], i[0] } );
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, d ) );
        return;
    }
}
