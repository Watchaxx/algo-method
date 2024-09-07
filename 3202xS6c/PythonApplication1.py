o = 0
x = 27

while x != 1:
    if x % 2 != 0:
        x = x * 3 + 1
    else:
        x //= 2
    o += 1
print(o)
