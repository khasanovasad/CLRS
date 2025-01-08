namespace CLRS.LeetCode;

// problem #347: Top K Frequent Elements
public partial class Solution
{
    // time: O (n) + O (m * logk) + O (n * logk) = O (n * logk)
    // space: O (m) + O (k) + O (k) = O (m)
    // m is the number of unique elements in nums array
    public int[] TopKFrequent(int[] nums, int k)
    {
        // O (n)
        var map = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (map.ContainsKey(num))
            {
                map[num]++;
            }
            else
            {
                map.Add(num, 1);
            }
        }

        // O (m * logk)
        var heap = new PriorityQueue<KeyValuePair<int, int>, int>();
        foreach (var (key, value) in map)
        {
            heap.Enqueue(new KeyValuePair<int, int>(key, value), value);
            if (heap.Count > k)
            {
                heap.Dequeue();
            }
        }

        // O (n * logk)
        var answer = new List<int>();
        for (int i = 0; i < k; ++i)
        {
            answer.Add(heap.Dequeue().Key);
        }

        return answer.ToArray();
    }
}
