using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        const int m = 1000003;
        int[] a = new int[m + 1];
        string[] s = ReadLine().Split( ' ' );

        foreach( string s2 in s ) {
            int i = 0;
            long h = 0;

            foreach( char c in s2.Reverse() ) {
                h += ( c - 'a' + 1 ) * (long)System.Math.Pow( 30, i );
                i++;
            }
            a[h % m]++;
        }
        WriteLine( a.Max() );
        return;
    }
}
