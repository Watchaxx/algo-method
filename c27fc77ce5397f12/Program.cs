using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        int[] a = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int m = a[0];
        int s = 0;

        foreach( int i in a ) {
            s += i;
            m = System.Math.Max( m, s );
        }
        WriteLine( m );
        return;
    }
}
