using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] a  = Enumerable.Repeat( 0, nm[1] ).ToArray();
        long o = 0;

        foreach( int i in ReadLine().Split( ' ' ).Select( int.Parse ) ) {
            int x = i % nm[1];

            o += a[x];
            a[x]++;
        }
        WriteLine( o );
        return;
    }
}
