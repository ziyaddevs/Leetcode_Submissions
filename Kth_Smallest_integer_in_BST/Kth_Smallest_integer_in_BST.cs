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
    public int KthSmallest(TreeNode root, int k) {
        var stack = new Stack<TreeNode>();
        var curr = root;
        int count = 0;

        while (curr != null || stack.Count > 0)
        {
            // Reach the leftmost node
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }

            // Process the node
            curr = stack.Pop();
            count++;

            if(count == k)
            {
                return curr.val;
            }

            // Move to the right subtree
            curr = curr.right;
        }
        return -1; // this line should never be reached if k is valid
    }
}
