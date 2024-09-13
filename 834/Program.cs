using System;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string[] a = ReadLine().Split( ' ' );
        int q = int.Parse( ReadLine() );
        var d = new Deque<string>( n + q );

        foreach( string s in a ) {
            d.PushBack( s );
        }
        for( int i = 0; i < q; i++ ) {
            string[] t = ReadLine().Split( ' ' );

            switch( t[0] ) {
            case "0":
                d.PushFront( t[1] );
                break;
            case "1":
                d.PushBack( t[1] );
                break;
            case "2":
                try {
                    WriteLine( d[int.Parse( t[1] )] );
                } catch( ArgumentOutOfRangeException ) {
                    WriteLine( "Error" );
                }
                break;
            }
        }
        return;
    }
}

/// <summary>
/// C# で Deque を自作する
/// https://qiita.com/YuHima03/items/e52fdebdf626192c4b1e
/// </summary>
public class Deque<T>
{
    private int _cnt = 0;
    private int _head;
    private T[] _items;

    public Deque( int i )
    {
        int cap = i % 2 == 0 ? i + 1 : i;

        _items = new T[cap];
        _head = cap / 2;
    }

    public T this[int idx]
    {
        get {
            if( idx < 0 || _cnt <= idx ) {
                throw new ArgumentOutOfRangeException( nameof( idx ) );
            }
            return _items[_head + idx];
        }
        set {
            if( idx < 0 || _cnt <= idx ) {
                throw new ArgumentOutOfRangeException( nameof( idx ) );
            }
            _items[_head + idx] = value;
        }
    }

    private void Expand()
    {
        int newCap = Clamp( _items.Length << 1, 1, int.MaxValue );
        int frontCap = ( newCap - _cnt ) >> 1;

        if( frontCap == 0 ) {
            throw new Exception( "配列の長さが上限に到達" );
        }

        T[] newA = new T[newCap];

        Array.Copy( _items, _head, newA, frontCap, _cnt );
        _items = newA;
        _head = frontCap;
        return;
    }

    /// <summary>
    /// min と max の包括的な範囲にクランプされた value を返します。
    /// https://github.com/dotnet/runtime/blob/5535e31a712343a63f5d7d796cd874e563e5ac14/src/libraries/System.Private.CoreLib/src/System/Math.cs#L540C13-L554C26
    /// </summary>
    /// <param name="val">クランプする値</param>
    /// <param name="min">結果の下限</param>
    /// <param name="max">結果の上限</param>
    private int Clamp( int val, int min, int max )
    {
        if( max < min ) {
            throw new ArgumentException();
        }
        if( val < min ) {
            return min;
        } else if( max < val ) {
            return max;
        }
        return val;
    }

    public void PushBack( T item )
    {
        int idx = _head + _cnt;

        if( idx == _items.Length ) {
            Expand();
            idx = _head + _cnt;
        }
        _items[idx] = item;
        _cnt++;
        return;
    }

    public void PushFront( T item )
    {
        if( _head == 0 ) {
            Expand();
        }
        _items[--_head] = item;
        _cnt++;
        return;
    }
}
