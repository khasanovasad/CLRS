namespace CLRS.LeetCode;

// problem #543: Diameter of Binary Tree
public partial class Solution
{
    public int Diameter { get; set; }
    public int DiameterOfBinaryTree(TreeNode root) 
    {
        Dfs4(root);
        return Diameter;
    }

    public int Dfs4(TreeNode root)
    {
        if (root is null)
        {
            return 0;
        }

        var left = Dfs4(root.left);
        var right = Dfs4(root.right);

        Diameter = Math.Max(Diameter, left + right);

        return Math.Max(left, right) + 1;
    }
}
