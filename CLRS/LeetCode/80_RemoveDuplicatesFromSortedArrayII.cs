namespace CLRS.LeetCode;

// problem #80: Remove Duplicates from Sorted Array II
public partial class Solution
{
    //[1,1,1,2,2,3]
    // [0,0,1,1,1,1,2,3,3]
    public int RemoveDuplicatesII(int[] nums)
    {
        int n = nums.Length;
        int left = 1;
        int right = 1;
        int counter = 1;

        while (right < n)
        {
            if (nums[right] == nums[right - 1])
            {
                ++counter;

                if (counter > 2)
                {
                    ++right;
                    continue;
                }
            }
            else
            {
                counter = 1;
            }

            nums[left] = nums[right];
            ++left;
            ++right;
        }

        return left;
    }
}
