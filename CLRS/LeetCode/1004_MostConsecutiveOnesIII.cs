namespace CLRS.LeetCode;

// problem #1004: Most Consecutive Ones III 
public partial class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return 1;
        }

        int left = 0;

        int answer = 0;
        int current = 0;
        for (int right = 0; right < nums.Length; ++right)
        {
            if (nums[right] == 0)
            {
                ++current;
            }

            while (current > k)
            {
                if (nums[left] == 0)
                {
                    --current;
                }
                ++left;
            }

            answer = Math.Max(answer, right - left + 1);
        }

        return answer;
    }
}