using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] lr = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

        for( int i = lr[0]; i < lr[1]; i++ ) {
            for( int j = i + 10; j <= lr[1]; j += 10 ) {
                o++;
            }
        }
        WriteLine( o );
        return;
    }
}
