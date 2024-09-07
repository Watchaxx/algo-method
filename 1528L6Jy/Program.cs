using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        for( int i = 1; i <= n; i++ ) {
            if( i % 12 == 0 ) {
                WriteLine( "FizzBuzz" );
            } else if( i % 4 == 0 ) {
                WriteLine( "Fizz" );
            } else if( i % 6 == 0 ) {
                WriteLine( "Buzz" );
            } else {
                WriteLine( i );
            }
        }
        return;
    }
}
