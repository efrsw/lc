public record TreeNode(int val, TreeNode left, TreeNode right);

public int PathSum(TreeNode root, int targetSum)
{
    return 0;
}

public int CountTarget(List<int> path, int target)
{
    var (st, res) = (0, 0);
    var cur = path[st];

    for (var en = 1; en < path.Count; en++)
    {
        Console.WriteLine($"Cur:{cur}; St:{st}; En:{en}");
        if (cur + path[en] < target)
        {
            cur += path[en];
        }
        else if (cur + path[en] > target)
        {
            cur -= path[st];
            st++;
        }
        else
        {
            res++;
            cur -= path[st];
            st++;
        }
    }

    return res;
}

Console.WriteLine(CountTarget([5, 2, 1, 5], 8));
