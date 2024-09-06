def tax_included(price, rate):
    return price * (100 + rate) // 100

print(tax_included(int(input()), 10))
