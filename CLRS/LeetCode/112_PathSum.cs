namespace CLRS.LeetCode;

// problem #112: Path Sum
public partial class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return Dfs(root, 0, targetSum);
    }

    public bool Dfs(TreeNode root, int current, int targetSum)
    {
        if (root is null)
        {
            return false;
        }

        if (root.left is null && root.right is null)
        {
            return (root.val + current) == targetSum;
        }

        var left = Dfs(root.left, root.val + current, targetSum);
        var right = Dfs(root.right, root.val + current, targetSum);

        return left || right;
    }
}

