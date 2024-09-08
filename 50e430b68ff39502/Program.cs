using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        string s = ReadLine();
        var d = new SortedDictionary<char, int>();

        foreach( char chr in s ) {
            if( d.ContainsKey( chr ) != true ) {
                d.Add( chr, 1 );
            } else {
                d[chr]++;
            }
        }
        foreach( KeyValuePair<char, int> p in d ) {
            if( p.Value == d.Values.Max() ) {
                WriteLine( p.Key );
            }
        }
        return;
    }
}
