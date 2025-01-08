namespace CLRS.LeetCode;

// problem #1167: Minimum Cost to Connect Sticks
public partial class Solution
{
    public int ConnectSticks(int[] sticks)
    {
        var heap = new PriorityQueue<int, int>();

        foreach (int length in sticks)
        {
            heap.Enqueue(length, length);
        }

        int totalCost = 0;
        while (heap.Count > 1)
        {
            var resultingStick = heap.Dequeue() + heap.Dequeue();
            heap.Enqueue(resultingStick, resultingStick);

            totalCost += resultingStick;
        }

        return totalCost;
    }
}
