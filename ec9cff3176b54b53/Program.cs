using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int l = 0;
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] idx = new int[nm[1]];
        char[] s = ReadLine().ToCharArray();
        char[] t = ReadLine().ToCharArray();

        foreach( int i in Enumerable.Range( 0, nm[1] ) ) {
            idx[i] = System.Array.IndexOf( s, t[i], l );
            l = idx[i] + 1;
        }
        foreach( int i in Enumerable.Range( 1, nm[1] - 1 ) ) {
            if( idx[i] <= idx[i - 1] ) {
                WriteLine( "No" );
                return;
            }
        }
        WriteLine( "Yes" );
        return;
    }
}
