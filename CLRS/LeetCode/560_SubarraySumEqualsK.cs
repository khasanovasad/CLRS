namespace CLRS.LeetCode;

// problem #560: Subarray Sum Equals K
public partial class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        int answer = 0;
        var map = new Dictionary<int, int>
        {
            { 0, 1 }
        };

        int sum = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
            if (map.ContainsKey(sum - k))
            {
                answer += map[sum - k];
            }

            if (!map.ContainsKey(sum))
            {
                map.Add(sum, 0);
            }
            ++map[sum];
        }

        return answer;
    }
}
