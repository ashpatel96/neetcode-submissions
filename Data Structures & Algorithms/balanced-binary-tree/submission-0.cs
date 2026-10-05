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
    public bool IsBalanced(TreeNode root) {
        if(root == null){
            return true;
        }
        bool isBalanced = true;
        IsBalanced(root, ref isBalanced);
        return isBalanced;
    }
    public int IsBalanced(TreeNode root, ref bool isBalanced) {
        if(root == null){
            return 0;
        }
        int l = IsBalanced(root.left, ref isBalanced);
        int r = IsBalanced(root.right, ref isBalanced);

        if (Math.Abs(l -r) > 1) isBalanced = false;

        return Math.Max(l, r) + 1;
    }
}
