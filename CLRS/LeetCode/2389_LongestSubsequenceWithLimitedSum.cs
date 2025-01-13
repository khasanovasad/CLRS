namespace CLRS.LeetCode;

// problem #2389: Longest Subsequence With Limited Sum
// sort, prefix sum, binary search in prefix sum for query
// O (n * logn) + O (n) + O (m * logn) time complexity
public partial class Solution
{
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        Array.Sort(nums);

        var prefix = new int[nums.Length];
        int current = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            current += nums[i];
            prefix[i] = current;
        }

        var answer = new int[queries.Length];
        for (int i = 0; i < queries.Length; ++i)
        {
            answer[i] = InsertionPoint(prefix, queries[i]);
        }

        return answer;
    }

    public int InsertionPoint(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (right > left)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                // since arrays are 0 index based
                // the length of the subsequence is index + 1
                return mid + 1;
            }

            if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
        }

        // since arrays are 0 index based
        // the length of the subsequence is index + 1
        return nums[left] > target ? left : left + 1;
    }
}
