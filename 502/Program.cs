using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        var d = new System.Collections.Generic.Dictionary<int, int>( n );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Enumerable.Range( 0, n ) ) {
            d[i] = 0;
        }
        foreach( int i in a ) {
            d[i]++;
        }
        foreach( var p in d.OrderByDescending( x => x.Value ).ThenBy( x => x.Key ) ) {
            WriteLine( $"{p.Key} {p.Value}" );
        }
        Out.Flush();
        return;
    }
}
