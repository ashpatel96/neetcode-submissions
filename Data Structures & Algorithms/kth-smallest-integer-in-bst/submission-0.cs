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
        int answer = -1;
        InOrder(root, ref k, ref answer);
        return answer;
    }

    public void InOrder(TreeNode root, ref int k, ref int answer){
        if(root == null){
            return;
        }
        InOrder(root.left, ref k, ref answer);

        k--;
        if(k== 0) {
            answer = root.val;
        }
        InOrder(root.right, ref k, ref answer);
    }
}
