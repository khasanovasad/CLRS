namespace CLRS.LeetCode;

// problem #113: Path Sum II
public partial class Solution
{
    public IList<IList<int>> PathSumII(TreeNode root, int targetSum)
    {
        var answer = new List<IList<int>>();

        PathSumIIDfs(root, targetSum, 0, answer, []);

        return answer;
    }

    public bool PathSumIIDfs(TreeNode root, int targetSum, int currentSum, List<IList<int>> answer, List<int> currentList)
    {
        if (root is null)
        {
            return false;
        }

        if (root.left is null && root.right is null && currentSum + root.val == targetSum)
        {
            currentList.Add(root.val);
            answer.Add(currentList);
            return true;
        }

        bool left = PathSumIIDfs(root.left, targetSum, currentSum + root.val, answer, [.. currentList, root.val]);
        bool right = PathSumIIDfs(root.right, targetSum, currentSum + root.val, answer, [.. currentList, root.val]);
        return left || right;
    }
}
