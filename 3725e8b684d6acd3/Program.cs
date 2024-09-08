using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int q = int.Parse( ReadLine() );
        bool[] s = Repeat( false, 1001 ).ToArray();

        foreach( int i in Range( 0, q ) ) {
            int f = 0;
            int[] lr = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            foreach( int j in Range( lr[0], lr[1] - lr[0] + 1 ) ) {
                if( s[j] != true ) {
                    f++;
                }
            }
            if( f == lr[1] - lr[0] + 1 ) {
                foreach( int j in Range( lr[0], lr[1] - lr[0] + 1 ) ) {
                    s[j] = true;
                }
                WriteLine( "OK" );
            } else {
                WriteLine( "NG" );
            }
        }
        return;
    }
}
