namespace CLRS.LeetCode;

// problem #1046: Last Stone Weight
public partial class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var heap = new PriorityQueue<int, int>();
        foreach (int num in stones)
        {
            heap.Enqueue(num, -num);
        }

        while (heap.Count > 1)
        {
            var stone1 = Math.Abs(heap.Dequeue());
            var stone2 = Math.Abs(heap.Dequeue());

            if (stone1 != stone2)
            {
                heap.Enqueue(Math.Abs(stone1 - stone2), -(stone1 - stone2));
            }
        }

        return heap.Count == 1 ? heap.Dequeue() : 0;
    }
}
