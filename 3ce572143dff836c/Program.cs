using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] a = ReadLine().Trim().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] p = { a[2], a[3] };
        string[] s = new string[a[0]];

        foreach( int i in Enumerable.Range( 0, a[0] ) ) {
            s[i] = ReadLine();
        }
        ReadLine();

        string t = ReadLine();

        foreach( char c in t ) {
            switch( c ) {
            case 'U':
                if( 0 <= p[0] - 1 ) {
                    if( s[p[0] - 1][p[1]] != '#' ) {
                        p[0]--;
                    }
                }
                break;
            case 'D':
                if( p[0] + 1 < a[0] ) {
                    if( s[p[0] + 1][p[1]] != '#' ) {
                        p[0]++;
                    }
                }
                break;
            case 'L':
                if( 0 <= p[1] - 1 ) {
                    if( s[p[0]][p[1] - 1] != '#' ) {
                        p[1]--;
                    }
                }
                break;
            case 'R':
                if( p[1] + 1 < a[1] ) {
                    if( s[p[0]][p[1] + 1] != '#' ) {
                        p[1]++;
                    }
                }
                break;
            }
        }
        WriteLine( string.Join( " ", p ) );
        return;
    }
}
