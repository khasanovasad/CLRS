namespace CLRS.LeetCode;

// problem #121: Best Time to Buy and Sell Stock
public partial class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Count() < 2)
        {
            return 0;
        }

        int max = 0;
        int first = 0;
        int second = 1;

        while (first < prices.Count() && second < prices.Count())
        {
            int diff = prices[second] - prices[first];
            if (diff <= 0)
            {
                first = second;
                ++second;
                continue;
            }

            if (diff > 0 && diff > max)
            {
                max = diff;
            }
            ++second;
        }

        return max;
    }
}
