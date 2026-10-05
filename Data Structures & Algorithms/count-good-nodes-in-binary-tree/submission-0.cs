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
    public int GoodNodes(TreeNode root) {
        return GoodNodes(root, int.MinValue);
    }
    private int GoodNodes(TreeNode root, int max){
        if(root == null){
            return 0;
        }

        int count = 0;
        if(root.val >= max){
            count++;
            max = root.val;
        }
        int left = GoodNodes(root.left, max);
        int right = GoodNodes(root.right, max);

        return left + right + count;
    }

}
