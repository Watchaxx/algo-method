using System.Linq;
using static System.Console;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] b = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] c = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] o = { 0, 0, 0 };

        foreach( int i in Enumerable.Range( 1, n - 1 ) ) {
            int o1 = Min( Abs( a[i] - a[i - 1] ) + o[0], Abs( a[i] - b[i - 1] ) + o[1], Abs( a[i] - c[i - 1] ) + o[2] );
            int o2 = Min( Abs( b[i] - a[i - 1] ) + o[0], Abs( b[i] - b[i - 1] ) + o[1], Abs( b[i] - c[i - 1] ) + o[2] );
            int o3 = Min( Abs( c[i] - a[i - 1] ) + o[0], Abs( c[i] - b[i - 1] ) + o[1], Abs( c[i] - c[i - 1] ) + o[2] );

            o = new int[] { o1, o2, o3 };
        }
        WriteLine( o.Min() );
        return;
    }

    static int Min( int a, int b, int c )
    {
        return new int[] { a, b, c }.Min();
    }
}
