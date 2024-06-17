from functools import reduce


def minimumSubarrayLength(nums: list[int], k: int) -> int:
    mn = len(nums)
    exists = False

    for i in range(len(nums)):
        for j in range(i + 1, len(nums) + 1):
            cur = 0
            for n in nums[i:j]:
                cur |= n
            ln = j - i

            if cur >= k:
                mn = min(ln, mn)
                exists = True

    return mn if exists else -1


print(minimumSubarrayLength([1, 2, 3], 2))
