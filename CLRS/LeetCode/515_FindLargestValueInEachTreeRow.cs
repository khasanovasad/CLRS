namespace CLRS.LeetCode;

// problem #515: Find Largest Value In Each Tree Row
public partial class Solution
{
    public IList<int> LargestValues(TreeNode root)
    {
        if (root == null)
        {
            return new List<int>();
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var answer = new List<int>();


        while (queue.Any())
        {
            int currentLevelMax = Int32.MinValue;
            int nodesCount = queue.Count;

            for (int i = 0; i < nodesCount; ++i)
            {
                var node = queue.Dequeue();

                currentLevelMax = Math.Max(node.val, currentLevelMax);

                if (node.left is not null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right is not null)
                {
                    queue.Enqueue(node.right);
                }
            }

            answer.Add(currentLevelMax);
        }

        return answer;
    }
}
