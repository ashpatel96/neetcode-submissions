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
    public int DiameterOfBinaryTree(TreeNode root) {
        int best = 0;
        Height(root, ref best);
        return best;
    }
    public int Height(TreeNode root, ref int best){
        if (root == null){
            return 0;
        }
        int l = Height(root.left, ref best);
        int r = Height(root.right, ref best);

        best = Math.Max(best, l + r);
        return Math.Max(l, r) + 1;
    }
}
