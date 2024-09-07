import math

class MyFraction:
    def __init__(self, num, den):
        self.num = num
        self.den = den
        self.normalize()

    def normalize(self):
        g = math.gcd(self.num, self.den)
        self.num //= g
        self.den //= g
        if self.den < 0:
            self.num *= -1
            self.den *= -1

    def __str__(self): # print 関数の出力内容を定義するメソッド
        return f"{self.num}/{self.den}"

a = MyFraction(3, 4)
print(a) # 出力: 3/4

b = MyFraction(6, 8)
print(b) # 出力: 3/4

c = MyFraction(9, -6)
print(c) # 出力: -3/2

d = MyFraction(-10, -5)
print(d) # 出力: 2/1
