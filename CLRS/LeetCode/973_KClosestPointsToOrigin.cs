namespace CLRS.LeetCode;

// problem #973: K Closest Points to Origin
public partial class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        var heap = new PriorityQueue<int[], double>();
        foreach (int[] point in points)
        {
            double distance = Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
            heap.Enqueue(point, -distance);
            if (heap.Count > k)
            {
                heap.Dequeue();
            }
        }

        var answer = new List<int[]>();
        while (heap.Count > 0)
        {
            answer.Add(heap.Dequeue());
        }

        return answer.ToArray();
    }
}
