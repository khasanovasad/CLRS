namespace CLRS.LeetCode;

// 3105. Longest Strictly Increasing or Strictly Decreasing Subarray
public partial class Solution
{
    // [1,4,3,3,2]
    public int LongestMonotonicSubarray(int[] nums)
    {
        int left = 0;
        int right = 1;
        int answer = 0;
        while (right < nums.Length)
        {
            if (nums[right - 1] < nums[right])
            {
                answer = Math.Max(answer, right - left + 1);
            }
            else
            {
                left = right;
            }
            ++right;
        }

        left = 0;
        right = 1;
        while (right < nums.Length)
        {
            if (nums[right - 1] > nums[right])
            {
                answer = Math.Max(answer, right - left + 1);
            }
            else
            {
                left = right;
            }
            ++right;
        }

        return answer == 0 ? 1 : answer;
    }
}
