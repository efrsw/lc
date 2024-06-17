from typing import Optional
from TreeNode import TreeNode


class Solution:
    def isCousins(self, root: Optional[TreeNode], x: int, y: int) -> bool:
        results = [ None, None ]

        def find(root, cur_depth):
            if root is None: 
                return
            
            if root.val == x:
                results[0] = cur_depth
            elif root.val == y:
                results[1] = cur_depth
            
            find(root.left, cur_depth + 1)
            find(root.right, cur_depth + 1)

        find(root, 0)

        return results[0] == results[1]

