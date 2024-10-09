using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static List<int> o = new List<int>();

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = new int[n];
        var l = new List<int>[n];

        System.Array.ConstrainedCopy( ReadLine().Split( ' ' ).Select( int.Parse ).ToArray(), 0, a, 1, n - 1 );
        foreach( int i in Enumerable.Range( 0, n ) ) {
            l[i] = new List<int>();
        }
        foreach( int i in Enumerable.Range( 1, n - 1 ) ) {
            l[a[i]].Add( i );
        }
        Rec( 0, l );
        WriteLine( string.Join( " ", o ) );
        return;
    }

    static void Rec( int i, List<int>[] l )
    {
        foreach( int j in l[i] ) {
            Rec( j, l );
        }
        o.Add( i );
        return;
    }
}
