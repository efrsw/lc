from functools import reduce

def findColumnWith(grid: list[list[int]]) -> list[int]:
    def setMaxVal(input: tuple[int, int]):
        input = tuple([max(len(str(input[0])), len(str(input[1]))), input[1]])

    res: list[int] = [0 for _ in range(len(grid[0]))]

    map(lambda row: map(lambda col: col[0] = max(len(str(col[0])), len(str(col[1]))), zip(res, row)), grid)

    return res 
