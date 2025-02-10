namespace CLRS.LeetCode;

// 1708. Largest Subarray Length K
public partial class Solution
{
    public int[] LargestSubarray(int[] nums, int k)
    {
        int maxIndex = 0;
        for (int i = 0; i < nums.Length - k + 1; ++i)
        {
            if (nums[i] >= nums[maxIndex])
            {
                maxIndex = i;
            }
        }

        var result = new int[k];
        for (int i = 0; i < k; ++i)
        {
            result[i] = nums[maxIndex++];
        }

        return result;
    }

    /*
        To answer the follow up questions where there will be duplicates in the array:
        idk, as your mom
    */
}
