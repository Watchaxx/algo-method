using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static int[] p;
    static List<int>[] c;
    static List<int>[] l;

    static void Main()
    {
        int n = int.Parse( ReadLine() );

        p = Enumerable.Repeat( -1, n ).ToArray();
        c = new List<int>[n];
        l = new List<int>[n];
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() )
            { AutoFlush = false } );
        foreach( int i in Enumerable.Range( 0, n ) ) {
            c[i] = new List<int>();
            l[i] = new List<int>();
        }
        foreach( int _ in Enumerable.Range( 0, n - 1 ) ) {
            int[] t = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

            l[t[0]].Add( t[1] );
            l[t[1]].Add( t[0] );
        }
        Rec( 0 );
        foreach( int i in Enumerable.Range( 0, n ) ) {
            c[i].Sort();
        }
        foreach( int _ in Enumerable.Range( 0, int.Parse( ReadLine() ) ) ) {
            WriteLine( string.Join( " ", c[p[int.Parse( ReadLine() )]] ) );
        }
        Out.Flush();
        return;
    }

    static void Rec( int i )
    {
        foreach( int j in l[i].Where( x => x != p[i] ) ) {
            p[j] = i;
            c[i].Add( j );
            Rec( j );
        }
        return;
    }
}
