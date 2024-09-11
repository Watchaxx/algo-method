using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;

        while( 0 < n ) {
            n = n % 3 == 0 ? n /= 3 : n - 1;
            o++;
        }
        WriteLine( o );
        return;
    }
}
