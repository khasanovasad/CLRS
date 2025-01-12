namespace CLRS.LeetCode;

// problem #2294: Partition Array Such That Maximum Difference Is K
public partial class Solution
{
    public int PartitionArray(int[] nums, int k)
    {
        Array.Sort(nums);

        int answer = 1;
        int x = nums[0];
        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[i] - x > k)
            {
                answer++;
                x = nums[i];
            }
        }

        return answer;
    }
}
