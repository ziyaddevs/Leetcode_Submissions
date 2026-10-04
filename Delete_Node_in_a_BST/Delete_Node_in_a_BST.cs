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
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null) return null;

        // 1. Search for the node
        if ( key < root.val )
        {
            root.left = DeleteNode(root.left, key);
        }
        else if ( key > root.val )
        {
            root.right = DeleteNode(root.right, key);
        }
        else
        {
            // 2. we found the node to delete
            // Case 1 and 2: node has 0 or 1 child
            if (root.left == null) return root.right;
            if (root.right == null) return root.left;

            // Case 3: Two Children
            // Find the inorder successor (smallest in the right subtree)
            TreeNode curr = root.right;
            while (curr.left != null)
            {
                curr = curr.left;
            }

            // Replace value with successor's value
            root.val = curr.val;


            // Delete the dublicate successor node from the right subtree
            root.right = DeleteNode(root.right, curr.val);
        }
        return root;
    }
}