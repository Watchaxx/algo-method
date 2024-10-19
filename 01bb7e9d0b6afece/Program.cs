using static System.Console;

internal class Program
{
    static void Main()
    {
        int m = -1;
        string o = string.Empty;
        var d = new System.Collections.Generic.Dictionary<string, int>( int.Parse( ReadLine() ) );

        foreach( string t in ReadLine().Split( ' ' ) ) {
            if( d.ContainsKey( t ) != true ) {
                d[t] = 1;
            } else {
                d[t]++;
            }
        }
        foreach( var p in d ) {
            if( m < p.Value ) {
                m = p.Value;
                o = p.Key;
            } else if( 0 < string.Compare( o, p.Key, System.StringComparison.Ordinal ) && m == p.Value ) {
                o = p.Key;
            }
        }
        WriteLine( o );
        return;
    }
}
