using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] ac = System.Array.ConvertAll( ReadLine().Split( ' ' ), int.Parse );
        WriteLine( ac[0] ^ ac[1] );
        return;
    }
}
