def countPrefixes(words: list[str], s: str) -> int:
    res = 0;
    for prefix in words:
        res += all([p[0] == p[1] for p in zip(prefix, s[:len(prefix) + 1])])

    return res;

print([p for p in zip([1, 2, 3], [1, 2])])
