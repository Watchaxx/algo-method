using static System.Console;

internal class Program
{
    static void Main()
    {
        string s = ReadLine();

        for( int i = 1; i < s.Length; i++ ) {
            if( s[i] == s[i - 1] ) {
                WriteLine( "Yes" );
                return;
            }
        }
        WriteLine( "No" );
        return;
    }
}
