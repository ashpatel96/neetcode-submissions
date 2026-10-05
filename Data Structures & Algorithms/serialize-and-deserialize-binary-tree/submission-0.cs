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

public class Codec {
    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        var sb = new StringBuilder();
        Write(root, sb);
        return sb.ToString();
    }
    private void Write(TreeNode root, StringBuilder sb){
        if(root == null){
            sb.Append("#,");
            return;
        }
        sb.Append(root.val).Append(',');
        Write(root.left, sb);
        Write(root.right, sb);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        var _tokens = data.Split(',');
        int pos = 0;
        return Read(_tokens, ref pos);
    }

    private TreeNode Read(string[] tokens, ref int pos){
        string t = tokens[pos++];
        if(t == "#"){
            return null;
        }
        var root = new TreeNode(int.Parse(t));
        root.left = Read(tokens, ref pos);
        root.right = Read(tokens, ref pos);
        return root;
    }
}