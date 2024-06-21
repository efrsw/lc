public int MinDeletionSize(string[] strs)
{
    bool[] res = new bool[strs[0].Length];
    Array.Fill(res, true);

    for (int i = 0; i < strs[0].Length; i++)
    {
        strs
            .Select(str => str[i])
            .Aggregate((acc, val) =>
            {
                res[i] = res[i] & acc <= val;
                return val;
            });
    }

    return res.Select(x => x ? 0 : 1).Sum();
}

private string[] a = ["rrjk", "furt", "guzm"];
WriteLine(MinDeletionSize(a));
