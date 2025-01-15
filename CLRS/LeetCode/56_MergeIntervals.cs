namespace CLRS.LeetCode;

// problem #56: Merge Intervals
public partial class Solution
{
    public int[][] Merge (int[][] intervals)
    {
        var answer = new List<List<int>>();

        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        answer.Add(new List<int>(intervals[0]));

        for (int i = 1; i < intervals.Length; ++i)
        {
            if (intervals[i][0] <= answer.Last()[1])
            {
                answer.Last()[1] = Math.Max(intervals[i][1], answer.Last()[1]);
            }
            else
            {
                answer.Add(new List<int>(intervals[i]));
            }
        }

        return answer.Select(x => x.ToArray()).ToArray();
    }
}
