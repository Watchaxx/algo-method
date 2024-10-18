using System.Linq;
using static System.Console;

internal class Program
{
    class UnionFind
    {
        int[] Par;
        int[] Rnk;
        int[] Siz;
        uint[] Wei;

        public UnionFind( int n, uint[] w )
        {
            Par = Enumerable.Repeat( -1, n ).ToArray();
            Rnk = Enumerable.Repeat( 0, n ).ToArray();
            Siz = Enumerable.Repeat( 1, n ).ToArray();
            Wei = w;
        }

        public bool Unite( int x, int y )
        {
            int rx = Root( x );
            int ry = Root( y );

            if( rx == ry ) {
                return false;
            }
            if( Rnk[rx] < Rnk[ry] ) {
                Par[rx] = ry;
                Siz[ry] += Siz[rx];
                Wei[ry] += Wei[rx];
            } else {
                Par[ry] = rx;
                Siz[rx] += Siz[ry];
                Wei[rx] += Wei[ry];
                if( Rnk[rx] == Rnk[ry] ) {
                    Rnk[rx]++;
                }
            }
            return true;
        }

        private int Root( int x )
        {
            return Par[x] < 0 ? x : Root( Par[x] );
        }

        public uint Weight( int x )
        {
            return Wei[Root( x )];
        }
    }

    static void Main()
    {
        int[] nq = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        uint[] w = ReadLine().Split( ' ' ).Select( uint.Parse ).ToArray();
        var u = new UnionFind( nq[0], w );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Enumerable.Range( 0, nq[1] ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            if( t[0] == 0 ) {
                u.Unite( t[1], t[2] );
            } else if( t[0] == 1 ) {
                WriteLine( u.Weight( t[1] ) );
            }
        }
        Out.Flush();
        return;
    }
}
