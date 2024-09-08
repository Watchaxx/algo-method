using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var l = new System.Collections.Generic.List<string>( n ) { ReadLine() };

        for( int i = 1; i < n; i++ ) {
            string s = ReadLine();

            if( l.Contains( s ) == true ) {
                WriteLine( "No" );
                return;
            }
            if( s[0] != l[l.Count - 1][l[l.Count - 1].Length - 1] ) {
                WriteLine( "No" );
                return;
            }
            l.Add( s );
        }
        WriteLine( "Yes" );
        return;
    }
}
