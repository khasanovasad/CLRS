namespace CLRS.LeetCode;

// problem #100: Same Tree
public partial class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p is null && q is null)
        {
            return true;
        }

        if (p is null || q is null)
        {
            return false;
        }

        if (p.val != q.val)
        {
            return false;
        }

        var left = IsSameTree(p.left, q.left);
        var right = IsSameTree(p.right, q.right);

        return left && right;
    }
}
