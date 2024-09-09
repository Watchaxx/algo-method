using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int c = 0;
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        var d = new Dictionary<int, int>( n );

        foreach( int i in a ) {
            if( d.ContainsKey( i ) != true ) {
                d.Add( i, 1 );
            } else {
                d[i]++;
            }
        }
        foreach( KeyValuePair<int, int> p in d ) {
            if( p.Key < p.Value ) {
                c += p.Value - p.Key;
            } else if( p.Value < p.Key ) {
                c += p.Value;
            }
        }
        WriteLine( c );
        return;
    }
}
