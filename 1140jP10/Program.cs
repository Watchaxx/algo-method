using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] nxy = Console.ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        IEnumerable<int> lx = F1( nxy[1] );
        IEnumerable<int> ly = F1( nxy[2] );

        Console.WriteLine( F2( lx.Except( ly ) ) );
        return;
    }

    static IEnumerable<int> F1( int n )
    {
        string s = string.Join( "", Convert.ToString( n, 2 ).Reverse() );
        return Enumerable.Range( 0, s.Length ).Where( i => s[i] == '1' );
    }

    static double F2( IEnumerable<int> n )
    {
        double o = 0;

        foreach( double d in n ) {
            o += Math.Pow( 2, d );
        }
        return o;
    }
}
