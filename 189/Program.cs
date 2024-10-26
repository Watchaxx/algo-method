using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 1;

        for( int i = 0; i < n; i++ ) {
            o <<= 1;
        }
        WriteLine( o );
        return;
    }
}
