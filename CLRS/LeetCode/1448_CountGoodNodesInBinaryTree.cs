namespace CLRS.LeetCode;

// problem #1448: Count Good Nodes in Binary Tree
public partial class Solution
{
    public int GoodNodes(TreeNode root)
    {
        return Dfs2(root, Int32.MinValue);
    }

    public int Dfs1(TreeNode root, int maxSoFar)
    {
        if (root == null)
        {
            return 0;
        }

        int left = Dfs2(root.left, Math.Max(root.val, maxSoFar));
        int right = Dfs2(root.right, Math.Max(root.val, maxSoFar));

        int answer = left + right;
        if (root.val >= maxSoFar)
        {
            answer++;
        }

        return answer;
    }
}
