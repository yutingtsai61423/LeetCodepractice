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
    int res = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {   //維持一個區域變數, 以儲存目前最長的路徑 (左子樹節點個數+右子樹節點個數)

        //但DFS完 return 給上一個節點要是 max(左子樹, 右子樹) + 1 以表示這一側的最長路徑
        Dfs(root);
        return res;
    }

    public int Dfs(TreeNode node)
    {
        //遞迴的終點 子樹為空 沒有長度
        if (node == null) return 0;

        //往左找
        int left = Dfs(node.left);
        int right = Dfs(node.right);
        res = Math.Max(res, left + right);
        return 1 + Math.Max(left, right);
    }
}
