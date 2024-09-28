using System.Linq;
using System.Numerics;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        BigInteger[] a = ReadLine().Split( ' ' ).Select( BigInteger.Parse ).ToArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( BigInteger b in a ) {
            WriteLine( IsPrime( b ) ? "Yes" : "No" );
        }
        Out.Flush();
        return;
    }

    static bool IsPrime( BigInteger n )
    {
        if( n == 2 ) {
            return true;
        }
        if( n < 2 || n % 2 == 0 ) {
            return false;
        }

        int s = 0;
        int[] a = { 2, 325, 9375, 28178, 450775, 9780504, 1795265022 };
        BigInteger d = n - 1;

        while( d % 2 == 0 ) {
            d >>= 1;
            s++;
        }
        foreach( int b in a ) {
            if( b % n == 0 ) {
                return true;
            }

            int i = 0;
            BigInteger x = BigInteger.ModPow( b, d, n );

            if( x == 1 ) {
                continue;
            }
            for( i = 0; i < s; i++ ) {
                if( x == n - 1 ) {
                    break;
                }
                x = x * x % n;
            }
            if( i == s ) {
                return false;
            }
        }
        return true;
    }
}
