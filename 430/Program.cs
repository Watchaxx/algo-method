using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nlr = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

        WriteLine( Func( nlr[0], nlr[1], nlr[2] ) );
        return;
    }

    static int Func( int n, int l, int r )
    {
        return n == 0 ? 1 : r < l ? 0 : Func( n - 1, l + 1, r ) + Func( n, l + 1, r );
    }
}
