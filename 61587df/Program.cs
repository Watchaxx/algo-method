using System.Linq;
using static System.Console;

internal class Program
{
    static int tCnt = 0;
    static Task[] ta;

    class Task
    {
        public int I;
        public int T;
        public string S;

        public Task( int t, int i, string s )
        {
            I = i;
            S = s;
            T = t;
        }
    }

    static void Main()
    {
        int q = int.Parse( ReadLine() );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        ta = new Task[q];
        foreach( int i in Enumerable.Range( 0, q ) ) {
            string[] z = ReadLine().Split( ' ' );

            if( z[0] == "0" ) {
                int n = tCnt;

                ta[tCnt] = new Task( int.Parse( z[1] ), i, z[2] );
                tCnt++;
                while( 0 < n ) {
                    int p = ( n - 1 ) / 2;

                    if( ta[n].T < ta[p].T || ( ta[n].T == ta[p].T && ta[n].I < ta[p].I ) ) {
                        Task y = ta[n];
                        ta[n] = ta[p];
                        ta[p] = y;
                        n = p;
                    } else {
                        break;
                    }
                }
            } else if( z[0] == "1" ) {
                int n = 0;
                int l = 1;
                int r = 2;
                Task top = ta[0];

                ta[0] = ta[tCnt - 1];
                tCnt--;
                while( l < tCnt ) {
                    int s = n;

                    if( ta[l].T < ta[s].T || ( ta[l].T == ta[s].T && ta[l].I < ta[s].I ) ) {
                        s = l;
                    }
                    if( r < tCnt && ( ta[r].T < ta[s].T || ( ta[r].T == ta[s].T && ta[r].I < ta[s].I ) ) ) {
                        s = r;
                    }
                    if( n != s ) {
                        Task y = ta[n];
                        ta[n] = ta[s];
                        ta[s] = y;
                        n = s;
                        l = n * 2 + 1;
                        r = n * 2 + 2;
                    } else {
                        break;
                    }
                }
                WriteLine( top.S );
            }
        }
        Out.Flush();
        return;
    }
}
