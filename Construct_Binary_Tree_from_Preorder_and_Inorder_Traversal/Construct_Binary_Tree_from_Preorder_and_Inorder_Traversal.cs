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
    private int preorderIndex = 0;
    private Dictionary<int, int> inorderMap;

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        preorderIndex = 0;
        inorderMap = new Dictionary<int, int>();

        // Cache the indices of inorder elements for O(1) lookups
        for (int i = 0; i < inorder.Length; i++) {
            inorderMap[inorder[i]] = i;
        }

        return ArrayToTree(preorder, 0, inorder.Length - 1);
    }

    private TreeNode ArrayToTree(int[] preorder, int left, int right) {
        // Base case: no elements left to construct this subtree
        if (left > right) return null;

        // The current root is at preorderIndex; increment for the next recursive step
        int rootVal = preorder[preorderIndex++];
        TreeNode root = new TreeNode(rootVal);

        // Find the root index in the inorder array
        int mid = inorderMap[rootVal];

        // Recursively build the left and right subtrees
        root.left = ArrayToTree(preorder, left, mid - 1);
        root.right = ArrayToTree(preorder, mid + 1, right);

        return root;
    }
}