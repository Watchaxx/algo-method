using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        int idx = 1;
        var a = new System.Collections.Generic.SortedSet<int>( ReadLine().Split( ' ' ).Select( int.Parse ) );

        foreach( int i in a ) {
            if( i != idx ) {
                WriteLine( "No" );
                return;
            }
            idx++;
        }
        WriteLine( "Yes" );
        return;
    }
}
