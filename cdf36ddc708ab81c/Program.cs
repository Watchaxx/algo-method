using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string[] s = ReadLine().ToUpper().Split( ' ' );
        var sb = new System.Text.StringBuilder( n );

        for( int i = 0; i < n; i++ ) {
            sb.Append( s[i][0] );
        }
        WriteLine( sb );
        return;
    }
}
