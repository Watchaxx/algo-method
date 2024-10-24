internal class Program
{
    static void Main()
    {
        foreach( int i in new int[] { 3, -1, 0, 1, -13 } ) {
            System.Console.WriteLine( Sign( i ) );
        }
        return;
    }

    static string Sign( int n )
    {
        if( 0 < n ) {
            return "positive";
        } else if( n < 0 ) {
            return "negative";
        }
        return "zero";
    }
}
