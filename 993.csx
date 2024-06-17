public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public bool IsCousins(TreeNode root, int x, int y) {
        int?[] res = [null, null];
        const int xc = x;
        const int yc = y;

        void find(TreeNode? root, int curDepth) {
            if (root is null) return;

            switch(root.val) {
                case xc:
                    break;
                case y:
                    break
                default: 
                    break
            }
        }
    }
}
