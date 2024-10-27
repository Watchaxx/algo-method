using static System.Console;
using static System.Text.RegularExpressions.Regex;

internal class Program
{
    static void Main()
    {
        WriteLine( IsMatch( ReadLine(), @"^([a-z]+\-)*[a-z]+$" ) ? "Yes" : "No" );
        return;
    }
}
