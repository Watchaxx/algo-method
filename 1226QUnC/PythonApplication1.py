color_value = [
    [223,  19,  70,  58, 152, 237,  44, 142, 182, 188, 183],
    [ 54, 136, 156, 235, 115, 237,  57, 231, 232, 193, 253],
    [121, 211, 239, 164,  18, 254,  77, 194, 135, 156, 216],
    [ 59, 111,   2, 119,  87, 244,  44, 155, 146, 140, 207],
    [ 68, 200, 170, 188,  30, 187, 100,  34,  63,   6,   9],
    [202, 143, 171, 191, 247, 246, 154, 231, 239, 213, 159],
    [227,  92,  84,  64, 141, 167, 225,  41,   0,  29, 222],
    [ 79, 212, 136, 213, 220, 189,  95, 168, 222, 213,   0],
    [ 24, 223, 185,  36,  80, 212, 104, 133, 203, 217,  92],
    [ 28, 181, 182, 170,  67, 153, 108, 213, 133, 236,  90],
    [201,  70, 125,  97, 144, 227, 243,  14,   6, 108, 242]
]

for i in color_value:
    for j in i:
        print("#" if j <= 127 else ".", end="")
    print()
