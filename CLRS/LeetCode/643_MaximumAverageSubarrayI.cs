namespace CLRS.LeetCode;

// problem #643: Maximum Average Subarray I
public partial class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double current = 0;
        for (int i = 0; i < k; ++i)
        {
            current += nums[i];
        }
        current = current / k;

        double answer = current;
        for (int i = k; i < nums.Length; ++i)
        {
            var tempSum = current * k;
            tempSum -= nums[i - k];
            tempSum += nums[i];

            current = tempSum / k;

            answer = Math.Max(answer, current);
        }

        return answer;
    }
}