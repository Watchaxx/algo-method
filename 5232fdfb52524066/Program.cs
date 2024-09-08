using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        int[] a = ReadLine().Split( ' ' ).Select( int.Parse ).OrderByDescending( x => x ).ToArray();
        WriteLine( a[1] );
        return;
    }
}
