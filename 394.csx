Console.WriteLine(DecodeString("aa3[b2[c]]"));

public string DecodeString(string s)
{
    Stack<int> numbers = [];
    Stack<StringBuilder> sbs = [];
    var sb = new StringBuilder();
    var curDigit = 0;

    foreach (var c in s)
    {
        switch (c) 
        {
            case '0' or '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9': 
                curDigit = curDigit * 10 + (c - '0');
                break;
            case '[':
                numbers.Push(curDigit);
                curDigit = 0;
                sbs.Push(sb);
                sb = new();
                break;
            case ']':
                var k = numbers.Pop();
                var temp = sb;
                sb = sbs.Pop();
                while (k-- > 0) sb.Append(temp); 
                break;
            default:
                sb.Append(c);
                break;
        }
    }

    return sb.ToString();
}
