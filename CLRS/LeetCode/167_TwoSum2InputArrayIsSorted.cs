namespace CLRS.LeetCode;

// problem #167: Two Sum II
public partial class Solution
{
    // O (n log n)
    public int[] TwoSum21(int[] nums, int target)
    {
        var result = new int[2];

        for (int i = 0; i < nums.Length - 1; ++i)
        {
            var found = TwoSum21BinarySearch(nums, target - nums[i], i + 1);
            if (nums[i] + nums[found] == target)
            {
                return new int[2] { i + 1, found + 1 };
            }
        }        

        return result;
    }

    public int TwoSum21BinarySearch(int[] nums, int target, int start)
    {
        int left = start;
        int right = nums.Length - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] < target)
            {
                left = mid + 1; 
            }
            else
            {
                right = mid - 1;
            }
        }
        
        return left;
    }

    // O (n)
    public int[] TwoSum22(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            if (nums[left] + nums[right] == target)
            {
                return new int[2] { left + 1, right + 1 };
            }

            if (nums[left] + nums[right] > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return new int[2];
    }
}
