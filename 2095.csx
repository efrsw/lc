public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public ListNode DeleteMiddle(ListNode head)
{
    var (prev, cur, fast) = (head, head?.next, head?.next?.next);

    while (fast?.next is not null)
    {
        prev = prev.next;
        cur = cur.next;
        fast = fast?.next?.next;
    }

    prev.next = cur?.next;
    
    return head;
}

