namespace CLRS.LeetCode;

// problem #215: Kth Largest Element in an Array
public partial class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        var heap = new PriorityQueue<int, int>();
        foreach (int num in nums)
        {
            heap.Enqueue(num, -num);
        }

        int answer = 0;
        for (int i = 0; i < k; ++i)
        {
            answer = heap.Dequeue();
        }

        return answer;
    }
}
