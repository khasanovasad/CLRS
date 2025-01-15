namespace CLRS.LeetCode;

// problem #110: Balanced Binary Tree
public partial class Solution
{
    public class IsBalancedTreeInfo
    {
        public int Height;
        public bool IsBalanced;

        public IsBalancedTreeInfo(int height, bool isBalanced)
        {
            Height = height;
            IsBalanced = isBalanced;
        }
    }
    public bool IsBalanced(TreeNode root)
    {
        return IsBalancedHelper(root).IsBalanced;
    }

    public IsBalancedTreeInfo IsBalancedHelper(TreeNode root)
    {
        if (root is null)
        {
            return new IsBalancedTreeInfo(-1, true);
        }

        var leftInfo = IsBalancedHelper(root.left);
        if (!leftInfo.IsBalanced)
        {
            return new IsBalancedTreeInfo(-1, false);;
        }

        var rightInfo = IsBalancedHelper(root.left);
        if (!rightInfo.IsBalanced)
        {
            return new IsBalancedTreeInfo(-1, false);;
        }

        if (Math.Abs(leftInfo.Height - rightInfo.Height) <= 1)
        {
            return new IsBalancedTreeInfo(Math.Max(leftInfo.Height, rightInfo.Height) + 1, true);
        }

        return new IsBalancedTreeInfo(-1, false);
    }
}
