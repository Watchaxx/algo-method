using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nk = ReadLine().Trim().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] a  = ReadLine().Trim().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] x  = ReadLine().Trim().Split( ' ' ).Select( int.Parse ).ToArray();

        foreach( int b in a ) {
            int l = 0;
            int r = nk[1];

            while( l != r ) {
                int m = ( l + r ) / 2;

                if( b < x[m] ) {
                    r = m;
                } else {
                    l = m + 1;
                }
            }
            WriteLine( l );
        }
        return;
    }
}
