namespace CLRS.LeetCode;

// problem #121: Best Time to Buy and Sell Stock
public partial class Solution
{
    public int MaxProfitII(int[] prices)
    {
        int profit = 0;

        for (int i = 1; i < prices.Length; ++i)
        {
            if (prices[i] > prices[i - 1])
            {
                profit += prices[i] - prices[i - 1];
            }
        }

        return profit;
    }
}
