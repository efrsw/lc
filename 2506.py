def similarPairs(words: list[str]) -> int:
    counter = 0 
    for i in range(len(words) - 1):
        for k in range(len(words)):
            w1 = set(words[i])
            w2 = set(words[k])
            joined = w1 & w2

            if joined == len(w1) and joined == len(w2):
                counter += 1

    return counter
