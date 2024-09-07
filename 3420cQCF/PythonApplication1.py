S = input()
l = []

for c in S:
    if (ord("a") <= ord(c)) & (ord(c) <= ord("z")):
        if not (c == "a") | (c == "i") | (c == "u") | (c == "e") | (c == "o"):
            l.append("_")
            continue
    l.append(c)
print("".join(l))
