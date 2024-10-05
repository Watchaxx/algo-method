using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] s = new int[n];
        int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[][] a = new int[n][];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Enumerable.Range( 0, n ) ) {
            a[i] = new int[2];
            a[i][0] = i;
            a[i][1] = t[i];
        }
        a = a.OrderByDescending( x => x[1] ).ToArray();
        s[a[0][0]] = 0;
        for( int i = 1, c = 0; i < n; i++ ) {
            if( a[i][1] != a[i - 1][1] ) {
                c++;
            }
            s[a[i][0]] = c;
        }
        foreach( int i in s ) {
            WriteLine( i );
        }
        Out.Flush();
        return;
    }
}
