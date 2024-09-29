/*
ポラードのロー素因数分解法
https://algo-method.com/tasks/553/editorial

俺 PC (Core i9-9900K) だと 2400ms 程で終わるが，
提出すると 5500ms で Time Limit Exceeded になる
*/
using System.Collections.Generic;
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
            WriteLine( string.Join( " ", PollardsRho( b ) ) );
        }
        Out.Flush();
        return;
    }

    static List<BigInteger> PollardsRho( BigInteger n )
    {
        BigInteger p = Pollard( n );

        if( p == n ) {
            return new List<BigInteger> { p };
        }

        List<BigInteger> l = PollardsRho( p );

        l.AddRange( PollardsRho( n / p ) );
        return l.OrderBy( x => x ).ToList();
    }

    static BigInteger Pollard( BigInteger n )
    {
        if( n % 2 == 0 ) {
            return 2;
        }
        if( IsPrime( n ) == true ) {
            return n;
        }

        long s = 0;

        while( true ) {
            s++;

            BigInteger x = s;
            BigInteger y = ( x * x + s ) % n;

            while( true ) {
                BigInteger p = BigInteger.GreatestCommonDivisor( n, y - x + n );

                if( p == 0 || p == n ) {
                    break;
                }
                if( p != 1 ) {
                    return p;
                }
                x = ( x * x + s ) % n;

                BigInteger t = ( y * y + s ) % n;

                y = ( t * t + s ) % n;
            }
        }
    }

    static bool IsPrime( BigInteger n )
    {
        if( n == 2 || n == 3 ) {
            return true;
        }
        if( n < 2 || n % 2 == 0 ) {
            return false;
        }

        int[] a = { 2, 325, 9375, 28178, 450775, 9780504, 1795265022 };
        long s = 0;
        BigInteger d = n - 1;

        while( d % 2 == 0 ) {
            d >>= 1;
            s++;
        }
        foreach( int i in a ) {
            if( i % n == 0 ) {
                return true;
            }

            long j = 0;
            BigInteger x = BigInteger.ModPow( i, d, n );

            if( x == 1 ) {
                continue;
            }
            for( j = 0; j < s; j++ ) {
                if( x == n - 1 ) {
                    break;
                }
                x = x * x % n;
            }
            if( j == s ) {
                return false;
            }
        }
        return true;
    }
}
