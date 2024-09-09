using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        var l = new List<List<int>>( nm[0] );

        l.AddRange( Enumerable.Range( 0, nm[0] ).Select( i => new List<int>() ) );
        foreach( int i in Enumerable.Range( 0, nm[1] ) ) {
            int[] ab = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            l[ab[0]].Add( ab[1] );
            l[ab[1]].Add( ab[0] );
        }
        if( l[nm[2]].Count == nm[0] - 1 ) {
            WriteLine( 0 );
            return;
        }

        var f = new List<int>( nm[0] );

        foreach( int i in l[nm[2]] ) {
            f.AddRange( l[i] );
            f.Remove( nm[2] );
            f = f.OrderBy( x => x ).Distinct().Except( l[nm[2]] ).ToList();
        }
        WriteLine( f.Distinct().Count() );
        return;
    }
}
