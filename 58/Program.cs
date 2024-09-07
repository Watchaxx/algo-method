using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var s = new System.Text.StringBuilder( n );

        for( int i = 0; i < n; i++ ) {
            s.Append( ReadLine()[0] );
        }
        WriteLine( s );
        return;
    }
}
