using static System.Console;

internal class Program
{
    static void Main()
    {
        long n = long.Parse( ReadLine() );

        if( n < 2 ) {
            WriteLine( "No" );
            return;
        }
        for( long i = 2; i * i <= n; i++ ) {
            if( n % i == 0 ) {
                WriteLine( "No" );
                return;
            }
        }
        WriteLine( "Yes" );
        return;
    }
}
