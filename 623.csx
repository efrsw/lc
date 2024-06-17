#nullable enable

TreeNode left = new() { val = 2 };
TreeNode right = new() { val = 3 };
TreeNode root = new() { val = 1, left = left, right = right };

AddOneRow(root, 1, 1);

public TreeNode AddOneRow(TreeNode root, int val, int depth)
{
    void DFS(TreeNode node, int curDepth)
    {
        if (node is null) return;

        if (curDepth == depth - 1)
        {
            TreeNode nl = new() { val = val, left = node.left };
            TreeNode nr = new() { val = val, right = node.right };
            node.left = nl;
            node.right = nr;
            return;
        }

        DFS(node.left!, curDepth + 1);
        DFS(node.right!, curDepth + 1);
    }

    if (depth == 1) return new TreeNode() { val = val, left = root };

    DFS(root, 1);

    return root;
}

public class TreeNode
{
    public int val { get; set; }
    public TreeNode? left { get; set; }
    public TreeNode? right { get; set; }
}
