using static System.Console;
using static System.Text.RegularExpressions.Regex;

internal class Program
{
    static void Main()
    {
        WriteLine( IsMatch( ReadLine(), @"[a-zA-Z0-9]+\@[a-zA-Z0-9]+\.[a-zA-Z0-9]{1,4}$" ) ? "Yes" : "No" );
        return;
    }
}
