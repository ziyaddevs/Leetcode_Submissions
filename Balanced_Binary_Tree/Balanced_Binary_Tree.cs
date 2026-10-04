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
    public bool IsBalanced(TreeNode root)
    {
        return CheckHeight(root) != -1;
    }
    
    private int CheckHeight(TreeNode node)
    {
        if (node == null) return 0;

        // check left subtree height
        int leftHeight = CheckHeight(node.left);
        if (leftHeight == -1) return -1; // left subtree is not balanced

        // check right subtree height
        int rightHeight = CheckHeight(node.right);
        if (rightHeight == -1) return -1; // right subtree is not balanced

        // if subtree is differ in heigh by more than 1, return -1 (unbalanced)
        if (Math.Abs(leftHeight - rightHeight) > 1) return -1;

        // return the actual height of the current node
        return Math.Max(leftHeight, rightHeight) + 1;
    }
    
}

