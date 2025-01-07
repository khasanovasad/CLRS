namespace CLRS.LeetCode;

// problem #1026: Maximum Difference Between Noda and Ancestor
public partial class Solution
{
    public int MaxAncestorDiff(TreeNode root)
    {
        return Dfs3(root, root.val, root.val);
    }

    public int Dfs3(TreeNode root, int currMax, int currMin)
    {
        if (root == null)
        {
            return currMax - currMin;
        }

        var left = Dfs3(root.left, Math.Max(root.val, currMax), Math.Min(root.val, currMin));
        var right = Dfs3(root.right, Math.Max(root.val, currMax), Math.Min(root.val, currMin));

        return Math.Max(left, right);
    }
}
