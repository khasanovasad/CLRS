namespace CLRS.LeetCode;

// problem 199: Binary Tree Right Side View
public partial class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        if (root is null)
        {
            return new List<int>();
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var result = new List<int>();

        while (queue.Any())
        {
            var nodesCount = queue.Count;
            for (int i = 0; i < nodesCount; ++i)
            {
                var node = queue.Dequeue();

                if (nodesCount - 1 == i)
                {
                    result.Add(node.val);
                }

                if (node.left is not null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right is not null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }
        
        return result;
    }
}
