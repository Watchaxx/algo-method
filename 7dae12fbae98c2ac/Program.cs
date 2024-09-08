using System.Linq;
using static System.Console;
using static System.Text.RegularExpressions.Regex;

internal class Program
{
    static void Main()
    {
        string s = ReadLine();

        if( s.Length < 6 || 64 < s.Length ) {
            WriteLine( "invalid" );
            return;
        }

        bool[] b = Enumerable.Repeat( false, 5 ).ToArray();

        if( 10 <= s.Length ) {
            b[0] = true;
        }
        if( IsMatch( s, "[a-z]" ) == true ) {
            b[1] = true;
        }
        if( IsMatch( s, "[A-Z]" ) == true ) {
            b[2] = true;
        }
        if( IsMatch( s, "[0-9]" ) == true ) {
            b[3] = true;
        }
        if( IsMatch( s, "[!|?|@]" ) == true ) {
            b[4] = true;
        }
        if( b.Count( x => x == true ) <= 2 ) {
            WriteLine( "weak" );
        } else if( b.Count( x => x == true ) == 3 ) {
            WriteLine( "medium" );
        } else if( b.Count( x => x == true ) >= 4 ) {
            WriteLine( "strong" );
        }
        return;
    }
}
