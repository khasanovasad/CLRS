namespace CLRS.LeetCode;

// problem #2: Add Two Numbers
public partial class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode answer = new ListNode(0);
        ListNode l3 = answer;

        int tens = 0;
        int ones = 0;

        while (l1 is not null || l2 is not null)
        {
            int l1Val = (l1 is null) ? 0 : l1.val;
            int l2Val = (l2 is null) ? 0 : l2.val;

            var sum = l1Val + l2Val + tens;

            tens = sum / 10;
            ones = sum % 10;

            l3.next = new ListNode(ones);

            l1 = (l1 is null) ? null : l1.next;
            l2 = (l2 is null) ? null : l2.next;
            l3 = l3.next;
        }

        if (tens != 0)
        {
            l3.next = new ListNode(tens);
        }

        return answer.next;
    }
}
