using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int x = int.Parse( ReadLine() );
        int q = int.Parse( ReadLine() );
        var qu = new System.Collections.Generic.Queue<int>( q );

        foreach( int _ in Enumerable.Range( 0, q ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            if( t[0] == 0 ) {
                qu.Enqueue( t[1] + x );
            } else if( t[0] == 1 ) {
                while( 0 < qu.Count && qu.Peek() <= t[1] ) {
                    qu.Dequeue();
                    o++;
                }
                WriteLine( o );
            }
        }
        return;
    }
}
