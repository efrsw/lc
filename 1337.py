def kWeakestRows(mat: list[list[int]], k: int) -> list[int]:
    def binary_search(arr, target=0):
        l, r = 0, len(arr) - 1
        m = (l + r) // 2

        while l < r:
            if arr[m] > target:
                l = m + 1
                m = (l + r) // 2
            elif arr[m] <= target:
                r = m
                m = (l + r) // 2
            else:
                return l

        return l - 1
        
    res = []
    for i in range(len(mat)):
        res.append((i, binary_search(mat[i])))

    res.sort(key=lambda x: x[1])
    return [x[0] for x in res[:k]]


kWeakestRows(
    [
        [1, 1, 0, 0, 0],
        [1, 1, 1, 1, 0],
        [1, 0, 0, 0, 0],
        [1, 1, 0, 0, 0],
        [1, 1, 1, 1, 1],
    ],
    3,
)
