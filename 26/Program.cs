using static System.Console;

internal class Program
{
    static void Main()
    {
        string[] s = ReadLine().Split( ' ' );
        WriteLine( s[2] + s[1] + s[0] );
        return;
    }
}
