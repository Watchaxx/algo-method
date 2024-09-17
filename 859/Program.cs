using static System.Console;

internal class Program
{
    static void Main()
    {
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        // ↑が無いと不正解(時間切れ)になるヽ(`Д´)ﾉ
        int q = int.Parse( ReadLine() );
        int[] a = new int[20001];

        for( int i = -100; i <= 100; i++ ) {
            for( int j = -100; j <= 100; j++ ) {
                a[i * i + j * j]++;
            }
        }
        for( int i = 0; i < q; i++ ) {
            WriteLine( a[int.Parse( ReadLine() )] );
        }
        Out.Flush();
        return;
    }
}
