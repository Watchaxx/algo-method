using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        for( int i = 2; i <= n - i; i++ ) {
            if( IsPrime( i ) == true ) {
                for( int j = n - i; 2 <= j; j-- ) {
                    if( IsPrime( j ) == true ) {
                        if( i + j == n ) {
                            WriteLine( i );
                            return;
                        } else if( i + j < n ) {
                            break;
                        }
                    }
                }
            }
        }
        WriteLine( -1 );
        return;
    }

    static bool IsPrime( long n )
    {
        if( n == 2 ) {
            return true;
        } else if( n < 2 || n % 2 == 0 ) {
            return false;
        }
        for( int i = 3; i <= System.Math.Sqrt( n ); i += 2 ) {
            if( n % i == 0 ) {
                return false;
            }
        }
        return true;
    }
}
