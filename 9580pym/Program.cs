using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        WriteLine( int.Parse( ReadLine() ) - ReadLine().Split( ' ' ).Select( int.Parse ).Distinct().Count() );
        return;
    }
}
