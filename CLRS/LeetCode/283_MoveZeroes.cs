namespace CLRS.LeetCode;

// problem #283: Move Zeroes
public partial class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int left = 0;
        for (int right = 0; right < nums.Length; ++right)
        {
            if (nums[right] != 0)
            {
                var temp = nums[right];
                nums[right] = nums[left];
                nums[left] = temp;
                ++left;
            }
        }
    }
}