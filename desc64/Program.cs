using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        bool[] p = new bool[n + 1].Select( x => true ).ToArray();

        p[0] = false;
        p[1] = false;
        for( int i = 2; i <= n; i++ ) {
            if( p[i] != true ) {
                continue;
            }
            for( int j = i * 2; j <= n; j += i ) {
                p[j] = false;
            }
        }
        WriteLine( p[n] ? "Yes" : "No" );
        return;
    }
}
