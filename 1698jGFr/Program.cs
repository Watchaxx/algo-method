using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] d = { 0b1110111, 0b0100100, 0b1011101, 0b1101101, 0b0101110,
                    0b1101011, 0b1111011, 0b0100111, 0b1111111, 0b1101111 };
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        WriteLine( d[nm[0]] ^ d[nm[1]] );
        return;
    }
}
