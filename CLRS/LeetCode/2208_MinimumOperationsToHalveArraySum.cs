namespace CLRS.LeetCode;

// problem #2208: Minimum Operations to Halve Array Sum
public partial class Solution
{
    public int HalveArray(int[] nums)
    {
        var heap = new PriorityQueue<double, double>();
        double startingSum = 0;
        foreach (int num in nums)
        {
            startingSum += num;
            heap.Enqueue(num, -num);
        }

        double currentSum = startingSum;
        int operations = 0;

        while (startingSum / currentSum < 2)
        {
            var num = heap.Dequeue();
            heap.Enqueue(num / 2, -(num / 2));

            currentSum = currentSum - num + num / 2;

            operations++;
        }

        return operations;
    }
}
