public int RomanToInt(string s)
{
    var romans = new Dictionary<char, int>();
    romans.Add('I', 1);
    romans.Add('V', 5);
    romans.Add('X', 10);
    romans.Add('L', 50);
    romans.Add('C', 100);
    romans.Add('D', 500);
    romans.Add('M', 1000);

    HashSet<char> deducers = [ 'I', 'X', 'C' ];

    var (res, pos) = (0, 0);

    foreach (var c in s.Reverse())
    {
        switch (res) 
        {
            case <5:
                res += romans[c];
                break;
            default:
                if (deducers.Contains(c)) res -= romans[c];
                else res += romans[c];
                break;
        }
    }

    return res;
}

Console.WriteLine(RomanToInt("DCXXI"));
