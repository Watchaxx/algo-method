using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        var a = new System.Collections.Generic.List<int>( ReadLine().Split( ' ' ).Select( int.Parse ) );
        int q = int.Parse( ReadLine() );

        foreach( int _ in Enumerable.Range( 0, q ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            switch( t[0] ) {
            case 0:
                a.Reverse();
                break;
            case 1:
                a.Add( t[1] );
                break;
            case 2:
                if( 0 < a.Count ) {
                    WriteLine( a[a.Count - 1] );
                    a.RemoveAt( a.Count - 1 );
                } else {
                    WriteLine( "Error" );
                }
                break;
            }
        }
        return;
    }
}
