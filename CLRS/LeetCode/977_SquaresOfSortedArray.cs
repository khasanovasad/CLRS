namespace CLRS.LeetCode;

// problem #977: Squares Of Sorted Array
public partial class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int left = 0;
        int right = nums.Count() - 1;
        int[] result = new int[nums.Length];

        for (int i = nums.Length - 1; i >= 0; --i)
        {
            int square = 0;
            if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
            {
                square = nums[right];
                --right;
            }
            else
            {
                square = nums[left];
                ++left;
            }
            result[i] = square * square;
        }

        return result;
    }
}