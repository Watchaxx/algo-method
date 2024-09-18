using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] hw = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        string[] s = new string[hw[0]].Select( x => ReadLine() ).ToArray();
        bool[,] b = new bool[hw[0], hw[1]];

        for( int i = 0; i < 1 << hw[0] * hw[1]; i++ ) {
            foreach( int j in Enumerable.Range( 0, hw[0] ) ) {
                foreach( int k in Enumerable.Range( 0, hw[1] ) ) {
                    b[j, k] = s[j][k] == '#';
                }
            }
            foreach( int j in Enumerable.Range( 0, hw[0] * hw[1] ) ) {
                if( ( i & 1 << j ) == 1 << j ) {
                    int y = j / hw[1];
                    int x = j % hw[1];

                    b[y, x] = !b[y, x];
                    if( 0 < y ) {
                        b[y - 1, x] = !b[y - 1, x];
                    }
                    if( 0 < x ) {
                        b[y, x - 1] = !b[y, x - 1];
                    }
                    if( y < hw[0] - 1 ) {
                        b[y + 1, x] = !b[y + 1, x];
                    }
                    if( x < hw[1] - 1 ) {
                        b[y, x + 1] = !b[y, x + 1];
                    }
                }
            }

            bool o = true;

            foreach( int j in Enumerable.Range( 0, hw[0] ) ) {
                foreach( int k in Enumerable.Range( 0, hw[1] ) ) {
                    if( b[j, k] == true ) {
                        o = false;
                        break;
                    }
                }
            }
            if( o == true ) {
                WriteLine( "Yes" );
                return;
            }
        }
        WriteLine( "No" );
        return;
    }
}
