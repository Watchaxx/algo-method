num = int(input())

fruits_dict = {
    "apple": 120,
    "banana": 100,
    "peach": 150,
    "lemon": 90,
    "grape": 140,
    "orange": 80,
    "melon": 200,
    "pineapple": 160,
}
s = "empty"

fruits_dict = sorted(fruits_dict.items(), key=lambda kv: (kv[1], kv[0]), reverse=True)
for k, v in fruits_dict:
    if v <= num:
        s = k
        break
print(s)
