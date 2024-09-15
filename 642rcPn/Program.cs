using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 };
        int[] nx = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        bool[][] s = new bool[nx[0]][];
        var rng = Enumerable.Range( 0, nx[0] );

        foreach( int i in rng ) {
            string t = ReadLine();

            s[i] = new bool[nx[0]];
            foreach( int j in rng ) {
                s[i][j] = t[j] == '#';
            }
        }
        foreach( int _ in Enumerable.Range( 0, nx[1] ) ) {
            bool[][] next = new bool[nx[0]][];

            foreach( int i in rng ) {
                next[i] = Enumerable.Repeat( false, nx[0] ).ToArray();
            }
            foreach( int i in rng ) {
                foreach( int j in rng ) {
                    int a = 0;

                    foreach( int k in Enumerable.Range( 0, 8 ) ) {
                        int y = i + dy[k];
                        int x = j + dx[k];

                        if( ( 0 <= y && y < nx[0] ) && ( 0 <= x && x < nx[0] ) ) {
                            if( s[y][x] == true ) {
                                a++;
                            }
                        }
                    }
                    if( s[i][j] != true ) {
                        if( a == 3 ) {
                            next[i][j] = true;
                        }
                    } else {
                        next[i][j] = a == 2 || a == 3;
                    }
                }
            }
            s = next;
        }
        foreach( int i in rng ) {
            foreach( int j in rng ) {
                Write( s[i][j] ? '#' : '.' );
            }
            WriteLine();
        }
        return;
    }
}
