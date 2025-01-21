namespace CLRS.LeetCode;

// problem #674: Longest Continuous Increasing Subsequence
public partial class Solution
{
    public int FindLengthOfLCIS(int[] nums)
    {
        int answer = 1;

        int left = 0;
        int right = 1;
        int previous = nums[0];

        while (right < nums.Length)
        {
            if (nums[right] > previous)
            {
                answer = Math.Max(answer, right - left + 1);
            }
            else
            {
                left = right;
            }

            previous = nums[right];
            ++right;
        }

        return answer;
    }
}
