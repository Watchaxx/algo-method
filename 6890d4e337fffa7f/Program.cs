using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        WriteLine( t[1] - t[0] - ( t[3] - t[2] ) );
        return;
    }
}
