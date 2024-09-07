using static System.Console;

internal class Program
{
    static void Main()
    {
        for( int i = 1; i <= 31; i++ ) {
            Write( $"{i} " );
            if( i % 7 == 0 ) {
                WriteLine();
            }
        }
        return;
    }
}
