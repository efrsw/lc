public int EqualPairs(int[][] grid)
{
    var rowHashes = grid
        .GroupBy(
            x => string.Join(' ', x),
            x => x)
        .ToDictionary(k => k.Key, v => v.Count());
    
    int res = 0;
    for (int i = 0; i < grid[0].Length; i++)
    {
        var colHash = string.Join(' ', grid.Select(r => r[i]));
        res += rowHashes.GetValueOrDefault(colHash);
    }

    return res;
}

Console.WriteLine(EqualPairs([[3,2,1],[1,7,6],[2,7,7]]));

