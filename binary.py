def binary(arr, target=1):
    l,r = 0, len(arr)
    m = (l + r) // 2

    while l < r:
        if arr[m] > target:
            r = m
            m = (l + r) // 2
        elif arr[m] <= target:
            l = m + 1
            m = (l + r) // 2

    return l

print(binary([0, 0, 0, 1, 1]))
