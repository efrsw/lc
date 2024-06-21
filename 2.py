from typing import Optional


class ListNode:
    def __init__(self, val: int = 0, next: Optional["ListNode"] | None = None) -> None:
        self.val = val
        self.next = next


def addTwoNumbers(l1: ListNode | None, l2: ListNode | None) -> ListNode | None:
    def f(
        root1: ListNode | None,
        root2: ListNode | None,
        carry: int,
    ) -> ListNode | None:
        if root1 is None and root2 is None:
            return ListNode(carry, None) if carry is not 0 else None
        elif root1 is None and root2 is not None:
            return ListNode(
                (root2.val + carry) % 10, f(None, root2.next, (root2.val + carry) // 10)
            )
        elif root1 is not None and root2 is None:
            return ListNode(
                (root1.val + carry) % 10, f(None, root1.next, (root1.val + carry) // 10)
            )
        elif root1 is not None and root2 is not None:
            return ListNode(
                (root1.val + root2.val) % 10,
                f(root1.next, root2.next, (root1.val + root2.val + carry) // 10),
            )
        else:
            return

    newRoot = f(l1, l2, 0)

    return newRoot


list1 = ListNode(2, ListNode(4, ListNode(3)))
list2 = ListNode(5, ListNode(6, ListNode(4)))

print(addTwoNumbers(list1, list2))
