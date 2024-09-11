using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] w = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] s = w.OrderBy( x => x ).ToArray();

        foreach( int i in Enumerable.Range( 0, n ) ) {
            WriteLine( System.Array.BinarySearch( s, w[i] ) );
        }
        return;
    }
}
