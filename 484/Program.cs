using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] nk = Console.ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] a  = Console.ReadLine().Split( ' ' ).Select( int.Parse ).OrderByDescending( x => x ).ToArray();

        Array.Resize( ref a, nk[1] );
        Console.WriteLine( a.Sum() );
        return;
    }
}
