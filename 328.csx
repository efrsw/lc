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

public ListNode OddEvenList(ListNode head)
{
    var (rootOdd, rootEven) = (head, head?.next);

    if (rootOdd is null || rootEven is null) return head;

    var (cr, nx) = (rootOdd, rootEven);

    while (nx?.next is not null)
    {
        cr.next = null;
        cr.next = nx?.next;
        cr = cr.next;

        nx.next = null;
        nx.next = cr?.next;
        nx = nx.next;
    }

    cr.next = rootEven;

    return head;
}
