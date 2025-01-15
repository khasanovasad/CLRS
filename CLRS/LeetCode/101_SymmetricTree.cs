namespace CLRS.LeetCode;

// problem #101: Symmetric Tree
public partial class Solution
{
    public bool IsSymmetricBFS(TreeNode root)
    {
        if (root == null) return true;

        var queue = new Queue<(TreeNode, TreeNode)>();
        queue.Enqueue((root.left, root.right));

        while (queue.Count > 0)
        {
            var (left, right) = queue.Dequeue();

            if (left == null && right == null) continue;

            if (left == null || right == null || left.val != right.val) return false;

            queue.Enqueue((left.left, right.right));
            queue.Enqueue((left.right, right.left));
        }

        return true;
    }

    public bool IsSymmetricDFS(TreeNode root)
    {
        if (root == null) return true;

        return IsMirror(root.left, root.right);
    }

    public bool IsMirror(TreeNode left, TreeNode right)
    {
        if (left == null && right == null) return true;
        if (left == null || right == null) return false;
        if (left.val != right.val) return false;

        return IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
    }
}
