using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        WriteLine( Div( n, 5 ) );
        return;
    }

    static ulong Div( int n, int i )
    {
        ulong ret = 0;

        while( 0 < n ) {
            ret += (ulong)( n / i );
            n /= i;
        }
        return ret;
    }
}
