/// <summary>
/// N! が素数 p で何回割れるかを求めるルジャンドル関数
/// </summary>
/// <param name="n">N 階乗</param>
/// <param name="p">素数</param>
/// <returns>割れる回数</returns>
static long Legendre( long n, long p )
{
    long ret = 0;

    while( 0 < n ) {
        ret += n / p;
        n /= p;
    }
    return ret;
}
