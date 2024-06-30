namespace CLRS.LeetCode;

public partial class Solution
{
    public int MaxProduct(int[] nums)
    {
        int maxProduct = nums[0];
        int minProduct = nums[0];
        int result = nums[0];

        for (int i = 1; i < nums.Count(); ++i)
        {
            int current = nums[i];
            if (current < 0)
            {
                (maxProduct, minProduct) = (minProduct, maxProduct);
            }

            maxProduct = Math.Max(current, maxProduct * current);
            minProduct = Math.Min(current, minProduct * current);

            result = Math.Max(result, maxProduct);
        }

        return result;
    }
}
