using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        Console.ReadLine();
        int[] a = Console.ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        Console.WriteLine( Array.IndexOf( a, a.Max() ) );
        return;
    }
}
