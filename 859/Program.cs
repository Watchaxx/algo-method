using static System.Console;

internal class Program
{
    static void Main()
    {
        var sw = new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false };
        SetOut( sw );
        // ↑が無いと不正解(時間切れ)になるヽ(`Д´)ﾉ
        // SetOut( new ... ); と1行にまとめると何も出力されないヽ(`Д´)ﾉ
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
        sw.Dispose();
        return;
    }
}
