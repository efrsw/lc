public bool CloseStrings(string word1, string word2)
{
    Span<int> letters1 = stackalloc int[26];
    Span<int> letters2 = stackalloc int[26];

    foreach (var c in word1) letters1[c - 'a']++;
    foreach (var c in word2) letters2[c - 'a']++;

    // This code is used to determine if two words
    // has the same set of characters.
    for (var i = 0; i < letters1.Length; i++)
    {
        if (letters1[i] == 0 && letters2[i] != 0
            || letters2[i] == 0 && letters1[i] != 0) return false;
    }

    letters1.Sort();
    letters2.Sort();

    for (var i = 0; i < letters1.Length; i++)
        if (letters1[i] != letters2[i]) return false;

    return true;
}


Console.WriteLine(CloseStrings("abc", "bca"));
