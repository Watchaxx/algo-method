using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        decimal[] ta = Console.ReadLine().Split( ' ' ).Select( decimal.Parse ).ToArray();
        Console.WriteLine( ta[0] * Math.Ceiling( ta[1] / ta[0] ) );
        return;
    }
}
