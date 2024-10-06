using System.Collections.Generic;
using System.Linq;
using static System.Console;
using En = System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        WidthSea1();
        WidthSea2();
        return;
    }

    static void WidthSea1()
    {
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] dist = En.Repeat( -1, nm[0] ).ToArray();
        var g = new List<int>[nm[0]];
        var nodes = new List<List<int>>();

        foreach( int i in En.Range( 0, nm[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int _ in En.Range( 0, nm[1] ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            g[t[0]].Add( t[1] );
            g[t[1]].Add( t[0] );
        }
        dist[0] = 0;
        nodes.Add( new List<int>() { 0 } );
        foreach( int k in En.Range( 1, nm[0] - 1 ) ) {
            nodes.Add( new List<int>() );
            foreach( int v in nodes[k - 1] ) {
                foreach( int next_v in g[v] ) {
                    if( dist[next_v] == -1 ) {
                        dist[next_v] = dist[v] + 1;
                        nodes[k].Add( next_v );
                    }
                }
            }
            if( nodes[k].Count == 0 ) {
                break;
            }
        }
        foreach( var k in nodes ) {
            WriteLine( string.Join( " ", k.OrderBy( x => x ) ) );
        }
        return;
    }

    static void WidthSea2()
    {
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] dist = En.Repeat( -1, nm[0] ).ToArray();
        var g = new List<int>[nm[0]];
        var que = new Queue<int>( nm[0] );

        foreach( int i in En.Range( 0, nm[0] ) ) {
            g[i] = new List<int>();
        }
        foreach( int i in En.Range( 0, nm[1] ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            g[t[0]].Add( t[1] );
            g[t[1]].Add( t[0] );
        }
        dist[0] = 0;
        que.Enqueue( 0 );
        while( 0 < que.Count ) {
            int v = que.Dequeue();

            foreach( int next_v in g[v] ) {
                if( dist[next_v] == -1 ) {
                    dist[next_v] = dist[v] + 1;
                    que.Enqueue( next_v );
                }
            }
        }
        WriteLine( dist.Max() );
        return;
    }
}
