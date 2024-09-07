PI = 3.14

def men(r):
    print(f"半径 {r} cm の円の面積は {r*r*PI} cm^2")

def tai(r, h):
    print(f"底面の半径が {r} cm、高さが {h} cm の円柱の体積は {r*r*PI*h} cm^3")

men(3)
men(5)
men(10)
tai(2, 4)
tai(6, 10)
tai(10, 3)
