using static System.Console;
using static System.Text.RegularExpressions.Regex;

internal class Program
{
    static void Main()
    {
        string s = ReadLine();

        if( string.Compare( s, "埼玉県ささいたま市緑区新宿", System.StringComparison.Ordinal ) == 0
            || IsMatch( s, "(?<!さいたま)(?<!千葉)(?<!相模原)(?<!名古屋)市緑区" ) == true ) {
            WriteLine( "Yes" );
        } else {
            WriteLine( "No" );
        }
        return;
    }
}
