namespace CLRS.LeetCode;

// problem #26: Remove Duplicates from Sorted Array
public partial class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int left = 1;
        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[left] = nums[i];
                left++;
            }
        }

        return left + 1;
    }
}
