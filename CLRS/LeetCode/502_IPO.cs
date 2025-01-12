namespace CLRS.LeetCode;

// problem #502: IPO
// couldn't solve it, fuck this problem
public partial class Solution
{
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
    {
        var heap = new PriorityQueue<KeyValuePair<int, int>, (int profit, int capital)>();
        for (int i = 0; i < profits.Length; ++i)
        {
            int profit = profits[i];
            int cap = capital[i];

            heap.Enqueue(new KeyValuePair<int, int>(profit, cap), (-Math.Abs(profit - cap), cap));

            if (heap.Count > k)
            {
                heap.Dequeue();
            }
        }

        int maxProfit = w;
        while (heap.Count > 0)
        {
            var project = heap.Dequeue();
            if (maxProfit >= project.Value)
            {
                maxProfit += project.Key;
            }
            else
            {
                return maxProfit;
            }
        }
    
        return maxProfit;
    }
}
