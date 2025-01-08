namespace CLRS.LeetCode;

public partial class Solution
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        var heap = new PriorityQueue<int, (int priority, int order)>();
        int orderCount = 0;
        foreach (int num in arr)
        {
            heap.Enqueue(num, (-Math.Abs(num - x), -(orderCount++)));

            if (heap.Count > k)
            {
                heap.Dequeue();
            }
        }

        var answer = new List<int>();
        while (heap.Count > 0)
        {
            answer.Add(heap.Dequeue());
        }

        answer.Sort();
        return answer;
    }
}
