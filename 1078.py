def findOccurences(text: str, first: str, second: str) -> list[str]:
    res = set()

    words = text.split()
    for i in range(len(words) - 2):
        if words[i] == first and words[i + 1] == second:
            if words[i + 2] not in res:
                res.add(words[i + 2])

    return list(res)

print(findOccurences("alice is a good girl she is a good student", "a", "good")) 
