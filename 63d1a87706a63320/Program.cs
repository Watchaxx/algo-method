using System;
using System.Linq;

internal class Program
{
    static long[] memo = new long[100000];

    static void Main()
    {
        int n = int.Parse( Console.ReadLine() );

        Array.Resize( ref memo, n + 1 );
        memo = Enumerable.Repeat<long>( -1, n + 1 ).ToArray();
        Console.WriteLine( Tri( n ) );
        return;
    }

    static long Tri( int i )
    {
        return memo[i] != -1 ? memo[i] : ( memo[i] = i < 3 ? 1 : ( Tri( i - 1 ) + Tri( i - 2 ) + Tri( i - 3 ) ) % 1000000 );
    }
}
