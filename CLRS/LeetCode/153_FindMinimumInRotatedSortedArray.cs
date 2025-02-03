namespace CLRS.LeetCode;

// 153. Find Minimum in Rotated Sorted Array
public partial class Solution
{
    public int FindMin(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        if (nums[left] <= nums[right])
        {
            return nums[left];
        }

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[left] < nums[mid])
            {
                left = mid;
            }
            else if (nums[mid] < nums[right])
            {
                right = mid;
            }
            
            if (right - left + 1 == 2)
            {
                return Math.Min(nums[left], nums[right]);
            }
        }

        return left;
    }
}
