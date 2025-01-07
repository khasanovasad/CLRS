namespace CLRS.LeetCode;

// problem #236: Lowest Common Ancestor of a Binary Tree
public partial class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root is null)
        {
            return null;
        }

        // first case: p or q is the root meaning that the root is the
        // lower common ancestor
        if (root == p || root == q)
        {
            return root;
        }

        var left = LowestCommonAncestor(root.left, p, q);
        var right = LowestCommonAncestor(root.right, p, q);

        // second case: p and q are on the separate sides of the tree
        if (left is not null && right is not null)
        {
            return root;
        }

        // third case: p and q are on the same subtree
        if (left is not null)
        {
            return left;
        }

        return right;
    }
}
