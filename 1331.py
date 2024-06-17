def arrayRankTransform(arr: list[int]) -> list[int]:
    srt = sorted(arr)
    ranks = dict([(srt[i], i + 1) for i in range(len(srt))])

    return [ranks[n] for n in arr]

