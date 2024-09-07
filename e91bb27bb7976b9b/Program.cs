using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        WriteLine( string.Join( "\n", ReadLine().Split( ' ' ).Reverse() ) );
        return;
    }
}
