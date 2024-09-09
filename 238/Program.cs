using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] lr = Console.ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

        for( int i = lr[0]; i <= lr[1]; i++ ) {
            string s = $"{i}";

            if( string.Compare( s, string.Join( "", s.Reverse() ), StringComparison.Ordinal ) == 0 ) {
                o++;
            }
        }
        Console.WriteLine( o );
        return;
    }
}
