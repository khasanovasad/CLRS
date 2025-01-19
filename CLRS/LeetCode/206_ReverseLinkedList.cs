namespace CLRS.LeetCode;

// problem #206: Reverse Linked List
public partial class Solution
{
    // [1->2->3->4->5]
    // [2->1->[3]->4->5]
    public ListNode ReverseList(ListNode head)
    {
        var dummyHead = head;
        var dummyNode = head;

        while (dummyNode is not null && dummyNode.next is not null)
        {
            var tempNode = dummyNode.next;
            dummyNode.next = dummyNode.next.next;

            tempNode.next = dummyHead;
            dummyHead = tempNode;
        }

        return dummyHead;
    }
}
