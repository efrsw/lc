class Node:
    def __init__(self, val=None, children=None):
        self.val = val
        self.children = children

def maxDepth(root: Node) -> int:
    def dfs(node: Node, cur_depth: int, depths: list[int]):
        if not node:
            return

        depths.append(cur_depth)
        
        if node.children is not None:
            for child in node.children:
                dfs(child, cur_depth + 1, depths)
    
    mx = []
    dfs(root, 0, mx)

    return max(mx)
