using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static int[] o;

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = new int[n];
        var l = new List<int>[n];

        o = new int[n];
        System.Array.ConstrainedCopy( ReadLine().Split( ' ' ).Select( int.Parse ).ToArray(), 0, a, 1, n - 1 );
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Enumerable.Range( 0, n ) ) {
            l[i] = new List<int>();
        }
        foreach( int i in Enumerable.Range( 1, n - 1 ) ) {
            l[a[i]].Add( i );
        }
        Rec( 0, l );
        foreach( int _ in Enumerable.Range( 0, int.Parse( ReadLine() ) ) ) {
            WriteLine( o[int.Parse( ReadLine() )] );
        }
        Out.Flush();
        return;
    }

    static int Rec( int i, List<int>[] l )
    {
        foreach( int j in l[i] ) {
            o[i] += Rec( j, l ) + 1;
        }
        return o[i];
    }
}
