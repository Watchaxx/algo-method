using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string s = ReadLine();
        var st = new System.Collections.Generic.Stack<char>( n );

        foreach( char c in s ) {
            if( c == '(' ) {
                st.Push( c );
            } else if( c == ')' && 0 < st.Count ) {
                st.Pop();
            } else {
                WriteLine( "No" );
                return;
            }
        }
        WriteLine( st.Count == 0 ? "Yes" : "No" );
        return;
    }
}
