namespace CLRS.LeetCode;

// problem #103: Binary Tree Zigzag Level Order Traversal
public partial class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        if (root == null)
        {
            return [];
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var answer = new List<IList<int>>();
        bool leftFirst = true;

        while (queue.Any())
        {
            int nodesCount = queue.Count;
            var currentLevelAnswer = new LinkedList<int>();

            for (int i = 0; i < nodesCount; ++i)
            {
                var node = queue.Dequeue();

                if (leftFirst)
                {
                    currentLevelAnswer.AddLast(node.val);
                }
                else
                {
                    currentLevelAnswer.AddFirst(node.val);
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

            answer.Add(new List<int>(currentLevelAnswer));
            leftFirst = !leftFirst;
        }

        return answer;
    }
}