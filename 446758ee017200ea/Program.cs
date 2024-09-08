using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        const int len = 5;
        int n = int.Parse( ReadLine() );
        int[] rng = Enumerable.Range( 0, len ).ToArray();
        var a = new List<List<int>>( 5 );

        foreach( int _ in rng ) {
            a.Add( ReadLine().Trim().Split( ' ' ).Select( int.Parse ).ToList() );
        }
        foreach( int i in Enumerable.Range( 0, n ) ) {
            int p = int.Parse( ReadLine() );

            foreach( int j in rng ) {
                int idx = a[j].IndexOf( p );

                if( 0 <= idx ) {
                    a[j][idx] = 0;
                    if( a[j].Sum() == 0 ) {
                        WriteLine( i );
                        return;
                    }

                    int sum = 0;

                    foreach( int k in rng ) {
                        sum += a[k][idx];
                        if( 0 < sum ) {
                            break;
                        }
                    }
                    if( sum == 0 ) {
                        WriteLine( i );
                        return;
                    }
                    sum = 0;
                    foreach( int k in rng ) {
                        sum += a[k][k];
                        if( 0 < sum ) {
                            break;
                        }
                    }
                    if( sum == 0 ) {
                        WriteLine( i );
                        return;
                    }
                    sum = 0;
                    foreach( int k in rng ) {
                        sum += a[rng.Reverse().ToArray()[k]][k];
                        if( 0 < sum ) {
                            break;
                        }
                    }
                    if( sum == 0 ) {
                        WriteLine( i );
                        return;
                    }
                    break;
                }
            }
        }
        WriteLine( -1 );
        return;
    }
}
