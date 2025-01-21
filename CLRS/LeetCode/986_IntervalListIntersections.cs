namespace CLRS.LeetCode;

// problem 986: Interval List Intersections
public partial class Solution
{
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
    {
        var answer = new List<List<int>>();
        int i = 0;
        int j = 0;

        while (i < firstList.Length && j < secondList.Length)
        {
            int maxStart = Math.Max(firstList[i][0], secondList[j][0]);
            int minEnd = Math.Min(firstList[i][1], secondList[j][1]);

            // means that the intersection exists
            if (maxStart <= minEnd)
            {
                answer.Add([maxStart, minEnd]);
            }

            if (firstList[i][1] > secondList[j][1])
            {
                ++j;
            }
            else
            {
                ++i;
            }
        }

        return answer.Select(x => x.ToArray()).ToArray();
    }
}
