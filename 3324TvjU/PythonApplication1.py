def chk(s):
    if len(s) < 5 or 12 < len(s):
        return False
    return s[0].isupper()

print("Yes" if chk(input()) else "No")
