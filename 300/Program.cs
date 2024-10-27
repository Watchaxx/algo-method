using static System.Console;

internal class Program
{
    static void Main()
    {
        string s = ReadLine();
        WriteLine( s.Contains( "cat" ) || s.Contains( "dog" ) ? "Yes" : "No" );
        return;
    }
}
