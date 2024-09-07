using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;
        string s = ReadLine();
        string t = ReadLine();

        for( int i = 0; i < n; i++ ) {
            if( s[i] != t[i] ) {
                o++;
            }
        }
        WriteLine( o );
        return;
    }
}
