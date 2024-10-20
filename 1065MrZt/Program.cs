using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int m = 0;
        int n = int.Parse( ReadLine() );
        int t = 0;
        int[] d = Enumerable.Repeat( -1, n ).ToArray();
        var l = new List<int>[n];
        var q = new Queue<int>( n );

        d[0] = 0;
        q.Enqueue( 0 );
        foreach( int i in Enumerable.Range( 0, n ) ) {
            l[i] = new List<int>();
        }
        foreach( int _ in Enumerable.Range( 0, n - 1 ) ) {
            int[] z = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            l[z[0]].Add( z[1] );
            l[z[1]].Add( z[0] );
        }
        while( 0 < q.Count ) {
            int a = q.Dequeue();

            foreach( int b in l[a].Where( x => d[x] == -1 ) ) {
                d[b] = d[a] + 1;
                q.Enqueue( b );
            }
        }
        m = d.Max();
        foreach( int i in Enumerable.Range( 0, n ).Where( x => d[x] == m ) ) {
            t = i;
        }
        foreach( int i in Enumerable.Range( 0, n ) ) {
            d[i] = -1;
        }
        d[t] = 0;
        q.Enqueue( t );
        while( 0 < q.Count ) {
            int a = q.Dequeue();

            foreach( int b in l[a].Where( x => d[x] == -1 ) ) {
                d[b] = d[a] + 1;
                q.Enqueue( b );
            }
        }
        m = d.Max();
        WriteLine( ( m + 1 ) / 2 );
        return;
    }
}
