namespace CLRS.LeetCode;

// problem #46: Permutations
// time complexity: O (n!) to find all permutations
// O (n^2) to for the for loop
// O (n! * n^2) for the entire algorithm but this is just
// an approximation. In reality, the time complexity
// of this algorithm is very complex mathematically
public partial class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        var answer = new List<IList<int>>();
        PermuteBacktrack(nums.ToList(), answer, Enumerable.Empty<int>().ToList());
        return answer;
    }

    public void PermuteBacktrack(List<int> nums, List<IList<int>> answer, List<int> current)
    {
        if (current.Count == nums.Count)
        {
            answer.Add(new List<int>(current));
            return;
        }

        foreach (int num in nums)
        {
            if (!current.Contains(num))
            {
                current.Add(num);
                PermuteBacktrack(nums, answer, current);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
