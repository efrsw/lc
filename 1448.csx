public class TreeNode
{
    public int val { get; set; }
    public TreeNode left { get; set; }
    public TreeNode right { get; set; }
}

public int GoodNodes(TreeNode root)
{
    int counter = 0;

    void DFS(TreeNode node, int mx)
    {
        switch (node.left is null, node.right is null)
        {
            case (true, true):
                if (node.val >= mx) counter++;
                return;

            case (true, false):
                if (node.val >= mx) counter++;
                DFS(node.right, Math.Max(mx, node.val));
                break;

            case (false, true):
                if (node.val >= mx) counter++;
                DFS(node.left, Math.Max(mx, node.val));
                break;

            case (false, false):
                if (node.val >= mx) counter++;
                DFS(node.left, Math.Max(mx, node.val));
                DFS(node.right, Math.Max(mx, node.val));
                break;
        }
    }
    
    DFS(root, root.val);

    return counter;
}
