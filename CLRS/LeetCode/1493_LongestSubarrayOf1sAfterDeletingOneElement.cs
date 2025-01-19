namespace CLRS.LeetCode;

// problem #1493: Longest Subarray of 1's After Deleting One Element
public partial class Solution
{
    public int LongestSubarray(int[] nums)
    {
        int answer = Int32.MinValue;
        int zeroCount = 0;
        int left = 0;
        int right = 0;
        while (right < nums.Length)
        {
            if (nums[right] == 0)
            {
                ++zeroCount;
            }

            while (zeroCount > 1)
            {
                if (nums[left] == 0)
                {
                    --zeroCount;
                }
                ++left;
            }
            answer = Math.Max(right - left + 1, answer);
            ++right;
        }

        return answer - 1;
    }
}