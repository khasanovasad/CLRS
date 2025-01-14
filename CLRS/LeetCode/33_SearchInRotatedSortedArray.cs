namespace CLRS.LeetCode;

// problem #33: Search in Rotated Sorted Array
// this is single pass binary search and a little hard to understand
// there is a simpler version that finds the pivot index, divides
// the array into two parts and then does binary search twice until
// it finds the target. If you wanna understand how this single pass
// binary search works, just copy and paste the code into ChatGPT
// and ask for expalanation.
// O (log n)
public partial class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[left] <= nums[mid])
            {
                if (target >= nums[left] && target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else if (nums[right] >= nums[mid])
            {
                if (target > nums[mid] && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }

        return -1;
    }
}
