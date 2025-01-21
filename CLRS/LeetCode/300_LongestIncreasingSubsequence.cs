namespace CLRS.LeetCode;

// problem #300: Longest Increasing Subsequence
public partial class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        var list = new List<int> { nums[0] };

        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[i] > list.Last())
            {
                list.Add(nums[i]);
            }
            else
            {
                var index = LengthOfLISBinarySearch(list, nums[i]);
                list[index] = nums[i];
            }
        }

        return list.Count;
    }

    public int LengthOfLISBinarySearch(List<int> list, int num)
    {
        int left = 0;
        int right = list.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (list[mid] == num)
            {
                return mid;
            }

            if (list[mid] > num)
            {
                left = mid + 1;
            }
            else if (list[mid] < num)
            {
                right = mid - 1;
            }
        }

        return right;
    }
}
