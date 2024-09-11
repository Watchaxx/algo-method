using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[][] a = new int[n][];
        int[][] p = new int[n][];

        foreach( int i in Enumerable.Range( 0, n ) ) {
            a[i] = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
            p[i] = new int[n];
        }
        p[0][n - 1] = a[0][n - 1];
        foreach( int i in Enumerable.Range( 1, n - 1 ) ) {
            p[i][n - 1] = p[i - 1][n - 1] + a[i][n - 1];
        }
        foreach( int i in Enumerable.Range( 0, n - 1 ).Reverse() ) {
            p[0][i] = p[0][i + 1] + a[0][i];
        }
        foreach( int i in Enumerable.Range( 1, n - 1 ) ) {
            foreach( int j in Enumerable.Range( 0, n - 1 ).Reverse() ) {
                p[i][j] = System.Math.Min( p[i - 1][j], p[i][j + 1] ) + a[i][j];
            }
        }
        WriteLine( p[n - 1][0] );
        return;
    }
}
