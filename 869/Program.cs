using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        decimal o = 0;
        int n = int.Parse( ReadLine() );
        var d = new System.Collections.Generic.Dictionary<string, int>( n );

        foreach( string s in ReadLine().Split( ' ' ).Select( x => string.Concat( x.OrderBy( c => c ) ) ) ) {
            if( d.ContainsKey( s ) != true ) {
                d.Add( s, 1 );
            } else {
                d[s]++;
            }
        }
        foreach( var p in d ) {
            o += Nc2( p.Value );
        }
        WriteLine( o / Nc2( n ) );
        return;
    }

    static decimal Nc2( int i )
    {
        return i * ( i - 1m ) / 2;
    }
}
