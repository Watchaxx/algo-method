using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        WriteLine( n - (int)System.Math.Sqrt( n ) );
        return;
    }
}
