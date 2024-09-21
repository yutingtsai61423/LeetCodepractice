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
    private bool isBalanced = true;
    public bool IsBalanced(TreeNode root)
    {
        //若底層節點平衡，可保證上層節點平衡，所以由底層節點開始計算
        //在current節點 回傳是否為平衡的樹 && 回傳自己的高度，已讓父節點判斷左右子樹是不是平衡

        GetHeight(root);

        return isBalanced;

    }

    public int GetHeight(TreeNode node)
    {
        if (node == null) return 0;
        int leftHeight = GetHeight(node.left);
        int rightHeight = GetHeight(node.right);

        if (Math.Abs(leftHeight - rightHeight) > 1 || isBalanced == false ) isBalanced = false;

        return 1 + Math.Max(leftHeight, rightHeight);

    }
}
