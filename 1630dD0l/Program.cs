using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nsk = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] v = Enumerable.Repeat( -1, nsk[0] ).ToArray();
        var l = new List<int>[nsk[0]];
        var q = new Queue<int>( nsk[0] );

        v[nsk[1]] = 0;
        q.Enqueue( nsk[1] );
        foreach( int i in Enumerable.Range( 0, nsk[0] ) ) {
            l[i] = new List<int>();
        }
        foreach( int _ in Enumerable.Range( 0, nsk[0] - 1 ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            l[t[0]].Add( t[1] );
            l[t[1]].Add( t[0] );
        }
        while( 0 < q.Count ) {
            int a = q.Dequeue();

            foreach( int b in l[a].Where( x => v[x] == -1 ) ) {
                v[b] = v[a] + 1;
                q.Enqueue( b );
            }
        }
        WriteLine( Enumerable.Range( 0, nsk[0] ).Count( x =>
            v[x] % 2 == nsk[2] % 2 && v[x] <= nsk[2] ) );
        return;
    }
}
