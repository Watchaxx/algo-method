using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        long[] a = ReadLine().Split( ' ' ).Select( long.Parse ).ToArray();
        long o = a.Sum() * a.Sum();

        for( int i = 0; i < n; i++ ) {
            o -= a[i] * a[i];
        }
        WriteLine( o / 2 );
        return;
    }
}
