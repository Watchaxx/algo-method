class MyFraction:
    def __init__(self, num, den):
        self.num = num # 分子
        self.den = den # 分母

    def ret(self):
        return f"{self.num}/{self.den}"

a = MyFraction(3, 4)
print(a.ret())
