using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        var s = new System.Collections.Generic.Stack<string>( ReadLine().Split( ' ' ) );
        int q = int.Parse( ReadLine() );

        for( int i = 0; i < q; i++ ) {
            string[] t = ReadLine().Split( ' ' );

            if( t[0] == "0" ) {
                s.Push( t[1] );
            } else if( t[0] == "1" ) {
                WriteLine( 0 < s.Count ? s.Pop() : "Error" );
            }
        }
        return;
    }
}
