using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] o = new int[257];
        string s = ReadLine();
        string t = ReadLine();

        o[0] = 0;
        for( int i = n - 1; i >= 0; i-- ) {
            if( t[i] == '1' ) {
                for( int j = 0; j <= i; j++ ) {
                    o[i - j + 1] += s[n - j - 1] - '0';
                }
            }
            o[i] += o[i + 1] / 2;
            o[i + 1] %= 2;
        }
        for( int i = 1; i <= n; i++ ) {
            Write( o[i] );
        }
        WriteLine();
        return;
    }
}
