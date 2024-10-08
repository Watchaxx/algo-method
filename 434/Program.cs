using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] p = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] a = new int[n];
        var l = new List<int>[n];

        foreach( int i in Enumerable.Range( 0, n ) ) {
            l[i] = new List<int>();
        }
        foreach( int i in Enumerable.Range( 1, n - 1 ) ) {
            l[p[i - 1]].Add( i );
        }
        Rec( 0, a, l );
        WriteLine( string.Join( "\n", a ) );
        return;
    }

    static int Rec( int i, int[] a, List<int>[] l )
    {
        foreach( int j in l[i] ) {
            a[i] += Rec( j, a, l );
        }
        return a[i] + 1;
    }
}
