from typing import Optional
from TreeNode import TreeNode


def isSubtree(self, root: Optional[TreeNode], subRoot: Optional[TreeNode]) -> bool:

    def dfs(root, target):
        if not root:
            return

        if root.val == target:
            possible_trees.append(root)

        dfs(root.left, target)
        dfs(root.right, target)

    def trees_equal(tree: Optional[TreeNode], subTree: Optional[TreeNode]) -> bool:
        match (tree, subTree):
            case (None, None):
                return True
            case (None, _):
                return False
            case (_, None):
                return False
            case (_, _):
                if tree.val != subTree.val:
                    return False
                else:
                    return trees_equal(tree.left, subTree.left) and trees_equal(tree.right, subTree.right)

    possible_trees = []

    if subRoot is None:
        return True

    dfs(root, subRoot.val)
    for i in possible_trees:
        if not trees_equal(root, i):
            return False

    return True

