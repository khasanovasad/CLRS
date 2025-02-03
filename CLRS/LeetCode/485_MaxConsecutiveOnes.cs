namespace CLRS.LeetCode;

//485. Max Consecutive Ones
public partial class Solution
{
    // [1,1,0,1,1,1]
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int right = 0;
        int answer = 0;
        int currentAnswer = 0;

        while (right < nums.Length)
        {
            if (nums[right] == 1)
            {
                ++currentAnswer;
            }
            else
            {
                answer = Math.Max(answer, currentAnswer);
                currentAnswer = 0;
            }
            ++right;
        }

        return answer;
    }
}
