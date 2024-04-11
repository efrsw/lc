public string DecodeString(string s)
{
    Stack<int> counts = [];
    Stack<string> result = [];
    string res = "";
    int i = 0;

    while (i < s.Length)
    {
        if (Char.IsNumber(s[i]))
        {
            var sb = new StringBuilder(s[i]);

            while (Char.IsNumber(s[i]))
            {
                sb.Append(s[i]);
                i++;
            }
            
            if (int.TryParse(sb.ToString(), out var n)) counts.Push(n);
        }
        else if (s[i] == '[')
        {
            result.Push(res);
            res = "";
            i++;
        }
        else if (s[i] == ']')
        {
            var count = counts.Pop();
            var sb = new StringBuilder(result.Pop());

            for (var k = 0; k < count; k++) sb.Append(res);

            res = sb.ToString();
            i++;
        }
        else 
        {
           res += s[i];
           i++;
        }
    }

    return res;
}

Console.WriteLine(DecodeString("3[a]2[bc]d"));
