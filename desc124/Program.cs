using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        long[] ab = ReadLine().Split( ' ' ).Select( long.Parse ).ToArray();

        WriteLine( $"最大公約数：{Gcd( ab[0], ab[1] )}" );
        WriteLine( $"最小公倍数：{Lcm( ab[0], ab[1] )}" );
        return;
    }

    /// <summary>
    /// 最大公約数
    /// </summary>
    static long Gcd( long a, long b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }

    /// <summary>
    /// 最小公倍数
    /// </summary>
    static long Lcm( long a, long b )
    {
        return a / Gcd( a, b ) * b;
    }
}
