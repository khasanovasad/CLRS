namespace CLRS.LeetCode;

// problem #55. Jump Game
public partial class Solution
{
    // [2,0,1,0,1]
    // [3,2,1,0,4]
    // [2,3,1,1,4]
    public bool CanJump(int[] nums)
    {
        int n = nums.Length;
        int lastPosition = nums.Length - 1;
        for (int i = n - 1; i >= 0; --i)
        {
            if (i + nums[i] >= lastPosition)
            {
                lastPosition = i;
            }
        }

        return lastPosition == 0;
    }
}
