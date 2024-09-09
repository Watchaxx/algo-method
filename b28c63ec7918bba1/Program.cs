using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    const int w = 5;
    static int h = 0;
    static string[] s;

    static void Main()
    {
        h = int.Parse( ReadLine() );
        s = new string[h];

        foreach( int i in Range( 0, h ) ) {
            s[i] = ReadLine();
        }
        while( true ) {
            bool del = false;

            foreach( int i in Range( 0, h ) ) {
                bool[] b = Repeat( false, 5 ).ToArray();

                foreach( int j in Range( 0, 3 ) ) {
                    if( s[i][j] == '0' ) {
                        continue;
                    }
                    if( s[i][j] == s[i][j + 1] && s[i][j + 1] == s[i][j + 2] ) {
                        b[j] = true;
                        b[j + 1] = true;
                        b[j + 2] = true;
                        del = true;
                    }
                }
                foreach( int j in Range( 0, w ) ) {
                    if( b[j] == true ) {
                        s[i] = Update( s[i], j, '0' );
                    }
                }
            }
            if( del != true ) {
                break;
            }
            foreach( int i in Range( 0, w ) ) {
                var l = new System.Collections.Generic.List<char>( h );

                foreach( int j in Range( 0, h ).Reverse() ) {
                    if( s[j][i] != '0' ) {
                        l.Add( s[j][i] );
                    }
                }
                while( l.Count < h ) {
                    l.Add( '0' );
                }

                int k = h - 1;

                foreach( char c in l ) {
                    s[k] = Update( s[k], i, c );
                    k--;
                }
            }
        }
        foreach( int i in Range( 0, h ) ) {
            WriteLine( s[i] );
        }
        return;
    }

    static string Update( string s, int i, char c )
    {
        char[] ca = s.ToCharArray();

        ca[i] = c;
        return string.Join( "", ca );
    }
}
