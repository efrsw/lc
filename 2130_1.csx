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

public int PairSum(ListNode head)
{
    var FindMiddle = (ListNode head) =>
    {

        var (slow, fast) = (head, head);

        while (fast?.next is not null)
        {
            slow = slow.next;
            fast = fast?.next?.next;
        }

        return slow;
    };

    var ReverseList = (ListNode head) =>
    {
        var (cr, nx) = (head, head?.next);

        while (nx is not null)
        {
            var _t = nx.next;
            nx.next = cr;
            cr.next = null;
            cr = nx;
            nx = _t;
        }

        return cr;    
    };

    var middle = FindMiddle(head);
    var tail = ReverseList(middle);
    var mx = head.val + tail.val;
     
    while (tail is not null)
    {
        mx = Math.Max(mx, head.val + tail.val); 
        tail = tail.next;
        head = head.next;
    }

    return mx;
}
