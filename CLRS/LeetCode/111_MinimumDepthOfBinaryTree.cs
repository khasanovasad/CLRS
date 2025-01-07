namespace CLRS.LeetCode;

// problem #111: Minimum Depth Of Binary Tree
public partial class Solution
{
    public int MinDepth(TreeNode root)
    {
        return Dfs2(root, 0);
    }

    public int Dfs2(TreeNode root, int currentDepth)
    {
        if (root is null)
        {
            return currentDepth;
        }

        if (root.left is null && root.right is null)
        {
            return currentDepth + 1;
        }

        int left = Int32.MaxValue;
        if (root.left is not null)
        {
            left = Dfs2(root.left, currentDepth + 1);
        }

        int right = Int32.MaxValue;
        if (root.right is not null)
        {
            right = Dfs2(root.right, currentDepth + 1);
        }

        return Math.Min(left, right);
    }
}

