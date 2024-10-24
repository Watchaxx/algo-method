class Program
{
    static void Main()
    {
        const string n1 = "kame??ar?ru";
        const string n2 = "??ma?oul?ru";

        for( int i = 0; i < n1.Length; i++ ) {
            if( n1[i] == '?' || n2[i] == '?' || n1[i] == n2[i] ) {
                continue;
            }
            System.Console.WriteLine( i );
        }
        return;
    }
}
