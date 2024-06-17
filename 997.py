def findJudge(n: int, trust: list[list[int]]) -> int:
    rels: dict[int, list[int]] = {}

    for p1, p2 in trust:
        match (p1 in rels, p2 in rels):
            case True, True:
                rels[p1][0] += 1
                rels[p2][1] += 1
            case True, False:
                rels[p1][0] += 1
                rels[p2] = [0, 1]
            case False, True:
                rels[p1] = [1, 0]
                rels[p2][1] += 1
            case False, False:
                rels[p1] = [1, 0]
                rels[p2] = [0, 1]

    for k, v in rels.items():
        if v[0] == 0 and v[1] == n - 1:
            return k

    return -1


print(findJudge(1, []))
