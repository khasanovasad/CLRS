using System.Text;

namespace CLRS.LeetCode;

// problem #136: Single Number
public partial class Solution
{
    public int SingleNumber(int[] nums)
    {
        int answer = 0;

        foreach (int num in nums)
        {
            answer ^= num;
        }
        return answer;
    }
}
