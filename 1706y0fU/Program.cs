using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var l = new System.Collections.Generic.List<int>();

        for( int i = 0; i < 30; i++ ) {
            if( ( n & ( 1 << i ) ) != 0 ) {
                l.Add( i );
            }
        }
        WriteLine( l.Count );
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
