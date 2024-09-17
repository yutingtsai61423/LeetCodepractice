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
    public int MaxDepth(TreeNode root) {
        //如果是空的節點 回傳深度為 0
        if (root == null)   return 0;

        //當下的節點最大深度=1 + 深度比較大的子樹 的深度

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
