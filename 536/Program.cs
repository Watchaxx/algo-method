using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] d = Enumerable.Repeat( 0, nm[0] ).ToArray();
        var l  = new List<int>();
        var ll = new List<int>[nm[0]];

        foreach( int i in Enumerable.Range( 0, nm[0] ) ) {
            ll[i] = new List<int>();
        }
        foreach( int _ in Enumerable.Range( 0, nm[1] ) ) {
            int[] fs = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            d[fs[1]]++;
            ll[fs[0]].Add( fs[1] );
        }
        foreach( int i in Enumerable.Range( 0, nm[0] ).Where( x => d[x] == 0 ) ) {
            l.Add( i );
        }
        while( 0 < l.Count ) {
            // C# 8.0 以降 l.Count - 1 -> ^0
            int t = l[l.Count - 1];

            l.RemoveAt( l.Count - 1 );
            foreach( int i in ll[t] ) {
                d[i]--;
                if( d[i] == 0 ) {
                    l.Add( i );
                }
            }
        }
        WriteLine( d.Sum() == 0 ? "Yes" : "No" );
        return;
    }
}
