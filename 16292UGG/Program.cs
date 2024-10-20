using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] v = Enumerable.Repeat( -1, n ).ToArray();
        var l = new List<int>[n];

        v[0] = 0;
        foreach( int i in Enumerable.Range( 0, n ) ) {
            l[i] = new List<int>();
        }
        foreach( int _ in Enumerable.Range( 0, n - 1 ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            l[t[0]].Add( t[1] );
        }
        WriteLine( Func( 0, -1, v, l ) ? "Yes" : "No" );
        return;
    }

    static bool Func( int a, int b, int[] v, List<int>[] l )
    {
        bool ret = true;

        foreach( int i in l[a] ) {
            if( v[i] == -1 ) {
                v[i] = v[a] ^ 1;
            } else if( v[i] == v[a] ) {
                return false;
            }
            ret &= Func( i, a, v, l );
        }
        return ret;
    }
}
