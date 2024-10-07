using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        bool[] p = new bool[nm[0]].Select( x => x = false ).ToArray();
        var g = new List<int>[nm[0]].Select( x => x = new List<int>() ).ToArray();

        foreach( int i in Enumerable.Range( 0, nm[1] ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            g[t[0]].Add( t[1] );
            g[t[1]].Add( t[0] );
        }
        foreach( int i in Enumerable.Range( 0, nm[0] ).Where( x => p[x] != true ) ) {
            o++;
            Rec( i, g, p );
        }
        WriteLine( o );
        return;
    }

    static void Rec( int v, List<int>[] g, bool[] p )
    {
        p[v] = true;
        foreach( int i in g[v].Where( x => p[x] != true ) ) {
            Rec( i, g, p );
        }
        return;
    }
}
