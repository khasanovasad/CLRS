namespace CLRS.LeetCode;

// problem #23: Merge k Sorted Lists

// explanation: this is a balanced merging tactic, meaning that the merged lists
// are of the same size (relatively) which results in balanced merging.
// in the sequential merge (if we merge the first 2 lists and then merge and 3rd list
// with the resulting list and so on), the resulting list size gets bigger and bigger
// as we progress through the list. That results in more comparisons which is
// omitted in divide and conquer method. Hence, the time complexity for
// sequential merge is O ( N * k ) and O (N * log k) for divide and conquer
public partial class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        int amount = lists.Length;
        int interval = 1;
        while (interval < amount)
        {
            for (int i = 0; i < amount - interval; i += interval * 2)
            {
                lists[i] = MergeTwoLists(lists[i] , lists[i + interval]);
            }
            interval *= 2;
        }

        return amount > 0 ? lists[0] : null;
    }
}
