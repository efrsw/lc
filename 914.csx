public bool HasGroupSizeX(int[] deck)
{
    var d = new Dictionary<int, int>();
    
    foreach (var card in deck)
    {
        if (d.TryGetValue(card, out var value)) d[card] = value + 1;
        else d.Add(card, 1);
    }

    var (max, min) = (d.Values.Max(), d.Values.Min());
    return min >= 1 && d.Values.All(x => x == max);
}
