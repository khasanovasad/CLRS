using System.Text;

namespace CLRS.LeetCode;

// problem #228. Summary Ranges
public partial class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var answer = new List<string>();

        int? previous = null;
        int? start = null;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (start is null)
            {
                start = nums[i];
            }

            if (previous is not null && nums[i] != previous + 1)
            {
                answer.Add(start == previous ? previous.ToString() : $"{start}->{previous}");
                previous = nums[i];
                start = nums[i];
            }
            else
            {
                previous = nums[i];
            }
        }

        var last = start == previous ? previous.ToString() : $"{start}->{previous}";
        if (!String.IsNullOrEmpty(last))
        {
            answer.Add(last);
        }

        return answer;
    }
}