using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        long[] abk = ReadLine().Split( ' ' ).Select( long.Parse ).ToArray();

        WriteLine( abk[2] % Gcd( abk[0], abk[1] ) == 0 && abk[2] <= System.Math.Max( abk[0], abk[1] ) ? "Yes" : "No" );
        return;
    }

    static decimal Gcd( long a, long b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
