namespace CLRS.LeetCode;

// problem #701: Insert into a Binary Search Tree
public partial class Solution
{
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root is null)
        {
            return new TreeNode(val);
        }

        if (root.val > val)
        {
            root.left = InsertIntoBST(root.left, val);
        }
        else
        {
            root.right = InsertIntoBST(root.right, val);
        }

        return root;
    }
}
