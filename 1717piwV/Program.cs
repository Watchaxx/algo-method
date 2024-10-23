using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] hw = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[][] ia1 = new int[hw[0]][];
        int[][] ia2 = new int[hw[0] - 1][];
        int m = ( hw[0] - 1 ) * hw[1] + hw[0] * ( hw[1] - 1 );
        int o = 0;
        var l = new System.Collections.Generic.List<Edge>();
        var u = new UnionFind( hw[0] * hw[1] );

        foreach( int i in Enumerable.Range( 0, hw[0] ) ) {
            ia1[i] = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        }
        foreach( int i in Enumerable.Range( 0, hw[0] - 1 ) ) {
            ia2[i] = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        }
        foreach( int i in Enumerable.Range( 0, hw[0] ) ) {
            foreach( int j in Enumerable.Range( 0, hw[1] - 1 ) ) {
                int a = i * hw[1] + j;
                int b = i * hw[1] + j + 1;

                l.Add( new Edge( a, b, ia1[i][j] ) );
                o += ia1[i][j];
            }
        }
        foreach( int i in Enumerable.Range( 0, hw[0] - 1 ) ) {
            foreach( int j in Enumerable.Range( 0, hw[1] ) ) {
                int a = i * hw[1] + j;
                int b = ( i + 1 ) * hw[1] + j;

                l.Add( new Edge( a, b, ia2[i][j] ) );
                o += ia2[i][j];
            }
        }
        l = l.OrderByDescending( x => x.W ).ToList();
        foreach( int i in Enumerable.Range( 0, m ) ) {
            Edge t = l[i];

            if( u.IsSame( t.U, t.V ) != true ) {
                u.Unite( t.U, t.V );
                o -= t.W;
            }
        }
        WriteLine( o );
        return;
    }
}

class Edge
{
    public int U;
    public int V;
    public int W;

    public Edge( int u, int v, int w )
    {
        U = u;
        V = v;
        W = w;
    }
}

class UnionFind
{
    int[] Par;
    int[] Siz;

    public UnionFind( int n )
    {
        Par = Enumerable.Range( 0, n ).ToArray();
        Siz = Enumerable.Repeat( 1, n ).ToArray();
    }

    public bool IsSame( int a, int b )
    {
        return Root( a ) == Root( b );
    }

    private int Root( int a )
    {
        return Par[a] == a ? a : Par[a] = Root( Par[a] );
    }

    public bool Unite( int a, int b )
    {
        int x = Root( a );
        int y = Root( b );

        if( x == y ) {
            return false;
        }
        if( Siz[x] < Siz[y] ) {
            int t = x;
            x = y;
            y = t;
        }
        Par[y] = x;
        Siz[x] += Siz[y];
        return true;
    }
}
