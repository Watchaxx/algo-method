using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int ob = 0;
        int ow = 0;
        int[] hw = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        bool[] bf = new bool[hw[1]];
        bool[] wf = new bool[hw[1]];
        bool[][] s = new bool[hw[0]][];
        var rngH = Enumerable.Range( 0, hw[0] );
        var rngW = Enumerable.Range( 0, hw[1] );

        foreach( int i in rngH ) {
            char[] t = ReadLine().ToCharArray();

            s[i] = new bool[hw[1]];
            foreach( int j in rngW ) {
                s[i][j] = t[j] == '#';
            }
        }
        foreach( int i in rngW ) {
            bf[i] = i % 2 == 0;
            wf[i] = i % 2 != 0;
        }
        foreach( int i in rngH ) {
            if( i % 2 == 0 ) {
                foreach( int j in rngW ) {
                    if( s[i][j] != bf[j] ) {
                        ob++;
                    }
                }
            } else {
                foreach( int j in rngW ) {
                    if( s[i][j] != wf[j] ) {
                        ob++;
                    }
                }
            }
        }
        foreach( int i in rngH ) {
            if( i % 2 == 0 ) {
                foreach( int j in rngW ) {
                    if( s[i][j] != wf[j] ) {
                        ow++;
                    }
                }
            } else {
                foreach( int j in rngW ) {
                    if( s[i][j] != bf[j] ) {
                        ow++;
                    }
                }
            }
            if( ob < ow ) {
                break;
            }
        }
        WriteLine( System.Math.Min( ob, ow ) );
        return;
    }
}
