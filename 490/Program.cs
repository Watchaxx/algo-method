using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int d = int.MaxValue;
        int[] nk = Console.ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] a  = Console.ReadLine().Split( ' ' ).Select( int.Parse ).OrderBy( n => n ).ToArray();

        foreach( int i in Enumerable.Range( 0, nk[0] - nk[1] + 1 ) ) {
            d = Math.Min( a[i + nk[1] - 1] - a[i], d );
        }
        Console.WriteLine( d );
        return;
    }
}
