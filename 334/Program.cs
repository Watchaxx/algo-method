using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( Console.ReadLine() );
        int[][] a = new int[n][];
        int[,] p = new int[n, n];

        foreach( int i in Enumerable.Range( 0, n ) ) {
            a[i] = Console.ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        }
        p[0, 0] = a[0][0];
        foreach( int i in Enumerable.Range( 0, n ) ) {
            foreach( int j in Enumerable.Range( 0, n ) ) {
                if( 0 <= i - 1 ) {
                    p[i, j] = Math.Max( p[i, j], p[i - 1, j] + a[i][j] );
                }
                if( 0 <= j - 1 ) {
                    p[i, j] = Math.Max( p[i, j], p[i, j - 1] + a[i][j] );
                }
            }
        }
        Console.WriteLine( p[n - 1, n - 1] );
        return;
    }
}
