public int MinCostToMoveChips(int[] position)
{
    var even = 0;

    foreach (var n in position)
    {
        even += (n % 2) switch
        {
            0 => 1,
            _ => 0
        };
    }

    return Math.Min(position.Length - even, even);
}
