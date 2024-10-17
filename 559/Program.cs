using System.Linq;
using static System.Console;

internal class Program
{
    class UnionFind
    {
        int[] Par;
        int[] Rank;
        int[] Size;

        public UnionFind( int n )
        {
            Par = Enumerable.Repeat( -1, n ).ToArray();
            Rank = Enumerable.Repeat( 0, n ).ToArray();
            Size = Enumerable.Repeat( 1, n ).ToArray();
        }

        public bool IsSame( int x, int y )
        {
            return Root( x ) == Root( y );
        }

        private int Root( int x )
        {
            return Par[x] == -1 ? x : Root( Par[x] );
        }

        public bool Unite( int x, int y )
        {
            int rx = Root( x );
            int ry = Root( y );

            if( rx == ry ) {
                return false;
            }
            if( Rank[rx] < Rank[ry] ) {
                int t = rx;
                rx = ry;
                ry = t;
            }
            Par[ry] = rx;
            if( Rank[rx] == Rank[ry] ) {
                Rank[rx]++;
            }
            Size[rx] += Size[ry];
            return true;
        }
    }

    static void Main()
    {
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        var u = new UnionFind( nm[0] );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Enumerable.Range( 0, nm[1] ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            if( u.IsSame( t[0], t[1] ) == true ) {
                WriteLine( "Yes" );
            } else {
                WriteLine( "No" );
                u.Unite( t[0], t[1] );
            }
        }
        Out.Flush();
        return;
    }
}
