namespace CLRS.LeetCode;

// problem #1302: Deepest Leaves Sum
public partial class Solution
{
    public int DeepestLeavesSum(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int answer = 0;

        while (queue.Any())
        {
            int nodesCount = queue.Count;
            answer = 0;

            for (int i = 0; i < nodesCount; ++i)
            {
                var node = queue.Dequeue();

                answer += node.val;

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

        return answer;
    }
}
