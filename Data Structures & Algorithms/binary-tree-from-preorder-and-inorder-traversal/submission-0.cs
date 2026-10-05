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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        var _idx = new Dictionary<int, int>();
        for(int i=0; i < inorder.Length;i++){
            _idx[inorder[i]] = i;
        }
        int _preIdx = 0;
        return Build(preorder, 0, inorder.Length -1, _idx, ref _preIdx);

    }
    private TreeNode Build(int[] preorder, int start, int end, Dictionary<int, int> idx, ref int _preIdx){
        if(start > end){
            return null;
        }
        int rootval = preorder[_preIdx++];
        var root = new TreeNode(rootval);
        int mid = idx[rootval];
        
        root.left = Build(preorder, start, mid -1, idx, ref _preIdx);
        root.right = Build(preorder, mid + 1, end, idx, ref _preIdx);

        return root;
    }
}
