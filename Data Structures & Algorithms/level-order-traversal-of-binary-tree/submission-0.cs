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
    public List<List<int>> LevelOrder(TreeNode root) {
        var res = new List<List<int>>();
        if (root == null){
            return res;
        }
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0){
            int size = q.Count;
            var level = new List<int>(size);
            for(int i=0; i < size; i++){
                var curr = q.Dequeue();
                level.Add(curr.val);
                if(curr.left != null){
                    q.Enqueue(curr.left);
                }
                if(curr.right != null){
                    q.Enqueue(curr.right);
                }
            }
            res.Add(level);
        }
        return res;
    }
}
