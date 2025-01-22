namespace CLRS.LeetCode;

// problem #189: Rotate Array
public partial class Solution
{
    // 1. reverse the whole array
    // 2. reverse the first k elements
    // 3. reverse the last n - k elements
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        
        // rotating the n=2 array 3 times
        // is equal to rotating the same array
        // once. So this is to find the minimum
        // rotations to get the same result without
        // getting index outside the bounds error
        k %= n;

        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
    }

    public void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            (nums[end], nums[start]) = (nums[start], nums[end]);
            ++start;
            --end;
        }
    }
}
