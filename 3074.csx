public int MinimumBoxes(int[] apple, int[] capacity)
{
    var totalApples = apple.Sum();

    for (var i = 0; i < capacity.Length; i++)
    {
        totalApples -= capacity[i];
        if (totalApples <= 0) return i + 1;
    }

    return capacity.Length;
}
