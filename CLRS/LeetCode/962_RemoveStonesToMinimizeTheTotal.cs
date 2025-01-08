namespace CLRS.LeetCode;

// problem #962: Remove Stones to Minimize the Total
public partial class Solution
{
    public int MinStoneSum(int[] piles, int k)
    {
        var heap = new PriorityQueue<int, int>();
        int currentSum = 0;

        foreach (int stones in piles)
        {
            currentSum += stones;
            heap.Enqueue(stones, -stones);
        }

        for (int i = 0; i < k; ++i)
        {
            int stones = heap.Dequeue();
            int remaining = stones - (int)Math.Floor((double)(stones / 2));

            currentSum = currentSum - stones + remaining;
            
            heap.Enqueue(remaining, -remaining);
        }

        return currentSum;
    }
}
