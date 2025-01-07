namespace CLRS.LeetCode;

// problem #938: Range Sum of BST
public partial class Solution
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root is null)
        {
            return 0;
        }

        int answer = 0;
        if (root.val >= low && root.val <= high)
        {
            answer = root.val;
        }

        if (low <= root.val)
        {
            answer += RangeSumBST(root.left, low, high);
        }

        if (high > root.val)
        {
            answer += RangeSumBST(root.right, low, high);
        }

        return answer;
    }
}
