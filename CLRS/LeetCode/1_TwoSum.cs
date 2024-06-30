namespace CLRS.LeetCode;

// problem #1: TwoSum
public partial class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Count(); ++i)
        {
            int num = nums[i];

            if (dict.ContainsKey(num))
            {
                return new int[] { dict[num], i };
            }

            dict[target - num] = i;
        }

        return new int[] { };
    }
}
