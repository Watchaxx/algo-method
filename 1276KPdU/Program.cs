using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] nk = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] a  = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        long o = 0;
        Heap h = new Heap( nk[0] );

        foreach( int i in a ) {
            o += i;
            h.Enqueue( -i );
        }
        foreach( int _ in Enumerable.Range( 0, nk[1] ) ) {
            int m = h.Dequeue();

            o += (long)System.Math.Floor( m / 2d );
            h.Enqueue( m / 2 );
        }
        WriteLine( o );
        return;
    }
}

/// <summary>
/// 優先度付きキュー | 備忘録
/// https://koseki2580.github.io/study-docs/docs/Data-Structure/priority-queue/
/// </summary>
class Heap
{
    int _size;
    int[] _heap;

    public Heap( int n )
    {
        _heap = new int[n];
        _size = 0;
    }

    public int Dequeue()
    {
        int ret = _heap[0];
        int n = 0;
        int x = _heap[--_size];

        while( n * 2 + 1 < _size ) {
            int a = n * 2 + 1;
            int b = n * 2 + 2;

            if( b < _size && _heap[b] < _heap[a] ) {
                a = b;
            }
            if( x <= _heap[a] ) {
                break;
            }
            _heap[n] = _heap[a];
            n = a;
        }
        _heap[n] = x;
        return ret;
    }

    public void Enqueue( int x )
    {
        int n = _size++;

        while( 0 < n ) {
            int p = ( n - 1 ) / 2;

            if( _heap[p] <= x ) {
                break;
            }
            _heap[n] = _heap[p];
            n = p;
        }
        _heap[n] = x;
        return;
    }
}
