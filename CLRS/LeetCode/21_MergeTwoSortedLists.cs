namespace CLRS.LeetCode;

// problem #21: Merge Two Sorted Lists
public partial class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummyHead = new ListNode();
        var list3 = dummyHead;

        while (list1 is not null || list2 is not null)
        {
            var l1Val = list1 is null ? Int32.MaxValue : list1.val;
            var l2Val = list2 is null ? Int32.MaxValue : list2.val;

            list3.next = new ListNode(Math.Min(l1Val, l2Val));
            list3 = list3.next;

            if (l1Val >= l2Val)
            {
                list2 = list2 is null ? null : list2.next;
            }
            else
            {
                list1 = list1 is null ? null : list1.next;
            }
        }

        return dummyHead.next;
    }
}
