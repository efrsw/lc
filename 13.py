def romanToInt(s: str) -> int:
    d = {"I": 1, "V": 5, "X": 10, "L": 50, "C": 100, "D": 500, "M": 1000}

    res = 0
    i = 0
    while i < len(s) - 1:
        match (s[i], s[i + 1]):
            case ("I", "V"):
                res += 4
                i += 1
            case ("I", "X"):
                res += 9
                i += 1
            case ("X", "L"):
                res += 40
                i += 1
            case ("X", "C"):
                res += 90
                i += 1
            case ("C", "D"):
                res += 400
                i += 1
            case ("C", "M"):
                res += 900
                i += 1
            case _:
                res += d[s[i]]
        i += 1

    return res if i == len(s) else res + d[s[i]]


print(romanToInt("LVIII"))
