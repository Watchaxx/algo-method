using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] hw = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] hor = Enumerable.Repeat( 0, hw[0] ).ToArray();
        int[] ver = Enumerable.Repeat( 0, hw[1] ).ToArray();
        bool[][] s = new bool[hw[0]][];

        foreach( int i in Enumerable.Range( 0, hw[0] ) ) {
            string t = ReadLine();

            hor[i] = t.Count( x => x == '#' );
            s[i] = new bool[hw[1]];
            foreach( int j in Enumerable.Range( 0, hw[1] ) ) {
                if( t[j] == '#' ) {
                    ver[j]++;
                }
                s[i][j] = t[j] == '#';
            }
        }

        int q = int.Parse( ReadLine() );
        int[] dy = { -1, 0, 0, 0, 1 };
        int[] dx = { 0, -1, 0, 1, 0 };

        foreach( int _ in Enumerable.Range( 0, q ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            if( t[0] == 0 ) {
                foreach( int i in Enumerable.Range( 0, 5 ) ) {
                    int y = t[1] + dy[i];
                    int x = t[2] + dx[i];

                    if( ( 0 <= y && y < hw[0] ) && ( 0 <= x && x < hw[1] ) ) {
                        hor[y] = s[y][x] ? hor[y] - 1 : hor[y] + 1;
                        ver[x] = s[y][x] ? ver[x] - 1 : ver[x] + 1;
                        s[y][x] = !s[y][x];
                    }
                }
            } else if( t[0] == 1 ) {
                WriteLine( s[t[1]][t[2]] ? hor[t[1]] + ver[t[2]] - 1 : hor[t[1]] + ver[t[2]] );
            }
        }
        return;
    }
}
