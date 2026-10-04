/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        var curr = root;

        while (curr != null)
        {
            if (curr.left == null)
            {
                result.Add(curr.val);
                curr = curr.right;
            }
            else
            {
                // find the inorder predecessor (rightmost node in the left subtree
                var prev = curr.left;
                while (prev.right != null && prev.right != curr)
                {
                    prev = prev.right;
                }

                // if the thread dosnt exist yet, create it and move left
                if (prev.right == null)
                {
                    prev.right = curr;
                    curr = curr.left;
                }
                else
                {
                    // thread already exists, break it, process current, and move right.
                    prev.right = null;
                    result.Add(curr.val);
                    curr = curr.right;
                }
            }
        }
        return result;
    }
}