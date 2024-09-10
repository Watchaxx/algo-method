using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        const int lim = 100000;
        int n = int.Parse( ReadLine() );
        int[] l = ReadLine().Split( ' ' ).Select( int.Parse ).OrderBy( x => x ).ToArray();
        int[] c1 = Enumerable.Repeat( 0, lim + 1 ).ToArray();
        int[] cs = Enumerable.Repeat( 0, lim + 2 ).ToArray();

        foreach( int i in Enumerable.Range( 0, n ) ) {
            c1[l[i]]++;
        }
        foreach( int i in Enumerable.Range( 1, lim + 1 ) ) {
            cs[i] = cs[i - 1] + c1[i - 1];
        }

        int q = int.Parse( ReadLine() );

        foreach( int _ in Enumerable.Range( 0, q ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            WriteLine( cs[t[1] + 1] - cs[t[0]] );
        }
        return;
    }
}
