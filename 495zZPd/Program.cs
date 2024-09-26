using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        long[] ab = ReadLine().Split( ' ' ).Select( long.Parse ).ToArray();
        WriteLine( ab[1] / Gcd( ab[0], ab[1] ) );
        return;
    }

    static decimal Gcd( long a, long b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
