using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        string[] s = Enumerable.Repeat( string.Empty, nm[0] ).ToArray();
        int c2 = 0;

        foreach( int i in Enumerable.Range( 0, nm[0] ) ) {
            s[i] = ReadLine();
        }
        foreach( int i in Enumerable.Range( 0, nm[0] - 1 ) ) {
            int c1 = 0;

            foreach( int j in Enumerable.Range( 0, nm[1] ) ) {
                if( s[i][j] != s[i + 1][j] ) {
                    c1++;
                }
            }
            if( c1 == 1 ) {
                c2++;
            }
        }
        WriteLine( c2 == nm[0] - 1 ? "Yes" : "No" );
        return;
    }
}
