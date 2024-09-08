using System;

internal class Program
{
    static void Main()
    {
        int m = int.Parse( Console.ReadLine() );
        int o = 0;
        char[] n = Console.ReadLine().ToCharArray();
        int y = n.Length - 1;

        for( int i = 0; i < n.Length; i++ ) {
            o += int.Parse( n[i].ToString() ) * (int)Math.Pow( m, y );
            y--;
        }
        Console.WriteLine( o );
        return;
    }
}
