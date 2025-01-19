namespace CLRS.LeetCode;

// problem #141: Linked List Cycle
public partial class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head is null)
        {
            return false;
        }

        var fast = head.next;
        var slow = head;

        while (fast is not null && fast.next is not null)
        {
            if (fast == slow)
            {
                return true;
            }

            fast = fast.next.next;
            slow = slow.next;
        }
        
        return false;
    }
}
