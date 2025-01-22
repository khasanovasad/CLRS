namespace CLRS.LeetCode;

// problem #121: Best Time to Buy and Sell Stock
public partial class Solution
{
    public int MaxProfit(int[] prices)
    {
        int answer = 0;    
        int lowestSoFar = Int32.MaxValue;
        for (int i = 0; i < prices.Length; ++i)
        {
            if (lowestSoFar >= prices[i])
            {
                lowestSoFar = prices[i];
                continue;
            }
            else
            {
                answer = Math.Max(answer, prices[i] - lowestSoFar);
            }
        }

        return answer;
    }
}
