using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] hw = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        string[] s = new string[hw[0]];

        foreach( int i in Enumerable.Range( 0, hw[0] ) ) {
            s[i] = ReadLine();
        }
        foreach( int i in Enumerable.Range( 0, hw[0] ) ) {
            foreach( int j in Enumerable.Range( 0, hw[1] ) ) {
                if( s[i][j] == '.' ) {
                    bool b = false;
                    int r = i;
                    int c = j;

                    foreach( int k in Enumerable.Range( -1, 3 ) ) {
                        foreach( int l in Enumerable.Range( -1, 3 ) ) {
                            if( k == 0 && l == 0 ) {
                                continue;
                            }

                            int w = 0;
                            int cr = r + k;
                            int cc = c + l;

                            while( 0 <= cr && cr < hw[0] && 0 <= cc && cc < hw[1] ) {
                                if( s[cr][cc] == 'x' ) {
                                    w++;
                                } else {
                                    if( s[cr][cc] == 'o' && 1 <= w ) {
                                        b = true;
                                    }
                                    break;
                                }
                                cr += k;
                                cc += l;
                            }
                        }
                    }
                    if( b == true ) {
                        o++;
                    }
                }
            }
        }
        WriteLine( o );
        return;
    }
}
