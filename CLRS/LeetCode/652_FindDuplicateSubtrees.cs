namespace CLRS.LeetCode;

// 652. Find Duplicate Subtrees
public partial class Solution
{
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
    {
        var answer = new List<TreeNode>();
        FindDuplicateSubtreesDfs(root, answer, [], []);
        return answer;
    }

    public int FindDuplicateSubtreesDfs(TreeNode node, List<TreeNode> answer, Dictionary<string, int> tripletToId, Dictionary<int, int> count)
    {
        if (node is null)
        {
            return 0;
        }

        var left = FindDuplicateSubtreesDfs(node.left, answer, tripletToId, count);
        var right = FindDuplicateSubtreesDfs(node.right, answer, tripletToId, count);

        var triplet = "(" + left + ")" + node.val + "(" + right + ")";

        if (!tripletToId.ContainsKey(triplet))
        {
            tripletToId.Add(triplet, tripletToId.Count);
        }
        ++tripletToId[triplet];

        var id = tripletToId[triplet];

        if (!count.ContainsKey(id))
        {
            count.Add(id, 0);
        }
        ++count[id];

        if (count[id] == 2)
        {
            answer.Add(node);
        }

        return id;
    }
}
