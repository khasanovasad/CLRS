namespace CLRS.LeetCode;

// problem #1481: Least Number of Unique Integers after K Removals
public partial class Solution
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        var map = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            if (map.ContainsKey(num))
            {
                map[num]++;
            }
            else
            {
                map[num] = 1;
            }
        }

        var heap = new PriorityQueue<KeyValuePair<int, int>, int>();
        foreach (var (key, value) in map)
        {
            heap.Enqueue(new (key, value), value);
        }

        for (int i = 0; i < k; ++i)
        {
            var top = heap.Dequeue();
            if (top.Value > 1)
            {
                heap.Enqueue(new (top.Key, top.Value - 1), top.Value - 1);
            }
        }

        return heap.Count;
    }
}
