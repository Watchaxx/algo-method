using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        int n = int.Parse( ReadLine() );
        int p = -1;
        int[] go = Enumerable.Repeat( -1, n ).ToArray();
        int[] zn = Enumerable.Repeat( -1, n ).ToArray();

        foreach( int i in ReadLine().Split( ' ' ).Select( int.Parse ) ) {
            zn[i] = p;
            if( 0 <= p ) {
                go[p] = i;
            }
            p = i;
        }
        foreach( int _ in Enumerable.Range( 0, int.Parse( ReadLine() ) ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
            int prev = zn[t[1]];
            int next = go[t[1]];

            if( t[0] == 0 ) {
                if( 0 <= prev ) {
                    int tmp = zn[prev];

                    zn[t[1]] = tmp;
                    zn[prev] = t[1];
                    if( 0 <= next ) {
                        zn[next] = prev;
                    }
                    go[prev] = next;
                    go[t[1]] = prev;
                    if( 0 <= tmp ) {
                        go[tmp] = t[1];
                    }
                    WriteLine( prev );
                } else {
                    WriteLine( "Error" );
                }
            } else if( t[0] == 1 ) {
                if( 0 <= next ) {
                    zn[next] = prev;
                }
                if( 0 <= prev ) {
                    go[prev] = next;
                }
                zn[t[1]] = -1;
                go[t[1]] = -1;
            }
        }
        Out.Flush();
        return;
    }
}
