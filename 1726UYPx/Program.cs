using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        int[] ns = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        foreach( int i in Enumerable.Range( 0, int.Parse( ReadLine() ) ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            switch( t[0] ) {
            case 0:
                ns[1] |= 1 << t[1];
                break;
            case 1:
                ns[1] &= ~( 1 << t[1] );
                break;
            case 2:
                WriteLine( 0 == ( ns[1] & 1 << t[1] ) ? "off" : "on" );
                break;
            }
        }
        Out.Flush();
        return;
    }
}
