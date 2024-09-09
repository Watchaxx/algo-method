using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

        WriteLine( Enumerable.Range( 1, n - 2 ).Count( i => a[i - 1] <= a[i] && a[i] >= a[i + 1] ) );
        return;
    }
}
