namespace CLRS.LeetCode;

// problem #57: Insert Interval

// Implemented two solutions
// 1. The good one runs in linear time with elegant logic: O (n) time and O (1) space (answer space isn't included)

// 2. Uses binary search to find the insert index, inserts the new interval
// and then runs Merge function from the previous 56th problem. Wastes a lot 
// of space too: O(log n) for binary search, O (n) for insert, and O (n) for merge resulting in O (n) time
// space: O (n) and O (n) again for merge but should really be O (n) once if we could rewrite the function better

public partial class Solution
{
    public int[][] InsertGood(int[][] intervals, int[] newInterval)
    {
        int i = 0;
        int n = intervals.Length;
        var answer = new List<int[]>();

        // 1. insert all intervals until we find a place for the new interval
        // no overlaps should occure in this process as the condition of the while loop
        while (i < n && intervals[i][1] < newInterval[0])
        {
            answer.Add(intervals[i]);
            ++i;
        }

        // 2. handle all overlapping intervals
        while (i < n && intervals[i][1] >= newInterval[0])
        {
            newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
            newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
            ++i;
        }

        // 3. insert the new interval
        answer.Add(newInterval);

        // 4. insert all other intervals
        // no overlaps should occure as that problem
        // was solved in the previous loop
        while (i < n)
        {
            answer.Add(intervals[i]);
            ++i;
        }

        return answer.ToArray();
    }

    #region INSERT AND CALL MERGE INTERVALS
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var merged = new List<int[]>(intervals);

        int insertIndex = InsertBinarySearch(intervals, newInterval);

        merged.Insert(insertIndex, newInterval);
        var answer = MergeWithoutSort(merged.ToArray());
        return answer;
    }

    public int InsertBinarySearch(int[][] intervals, int[] newInterval)
    {
        int left = 0;
        int right = intervals.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (intervals[mid][0] == newInterval[0])
            {
                return mid;
            }

            if (intervals[mid][0] < newInterval[0])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    public int[][] MergeWithoutSort(int[][] intervals)
    {
        var answer = new List<List<int>>();
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
    #endregion
}
