using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] a  = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        long[] b = Enumerable.Repeat<long>( 0, a.Max() + 2 ).ToArray();
        long o = 0;

        foreach( int i in a ) {
            b[i]++;
        }
        for( int i = 0; i < nm[1] / 2; i++ ) {
            o += b[i] * b[nm[1] - i];
        }
        if( nm[1] % 2 == 0 ) {
            o += b[nm[1] / 2] * ( b[nm[1] / 2] - 1 ) / 2;
        }
        WriteLine( o );
        return;
    }
}
