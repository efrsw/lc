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
        
        while (fast is not null)
        {
            slow = slow.next;
            fast = fast?.next?.next;
        }

        return slow;
    };

    var ReverseList = (ListNode head) => 
    {
        (ListNode pv, ListNode cr, ListNode nx) = (null, head, null);

        while (cr is not null)
        {
            nx = cr.next;
            cr.next = pv; 

            pv = cr;
            cr = nx;
        }

        return pv;
    };

    var middle = FindMiddle(head);
    var tail = ReverseList(middle);
    var mx = 0;

    while (tail.next is not null)
    {
        mx = Math.Max(mx, tail.val + head.val);
        head = head.next;
        tail = tail.next;
    }

    return mx;
}
