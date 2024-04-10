public string RemoveStars(string s)
{
    Stack<char> st = [];

    foreach (var c in s)
    {
        if (c == '*')
        {
            if (st.TryPeek(out var symbol)) st.Pop();
        }
        else
        {
            st.Push(c);
        }
    }
    
    // You can use String.Concat instead of Join on empty char (which is non-existent)
    return String.Concat(st.Reverse());
}

Console.WriteLine(RemoveStars("leet**cod*e"));
