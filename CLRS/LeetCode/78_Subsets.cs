namespace CLRS.LeetCode;

// problem #46: Subsets
// time complexity O(2^n * n)
public partial class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var answer = new List<IList<int>>();
        SubsetBacktrack(nums.ToList(), answer, Enumerable.Empty<int>().ToList(), 0);
        return answer;
    }

    public void SubsetBacktrack(List<int> nums, List<IList<int>> answer, List<int> current, int i)
    {
        if (i > nums.Count)
        {
            return;
        }

        answer.Add(new List<int>(current));
        for (int j = i; j < nums.Count; ++j)
        {
            current.Add(nums[j]);
            SubsetBacktrack(nums, answer, current, j + 1);
            current.RemoveAt(current.Count - 1);
        }
    }
}
