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
    bool isSameTreeFlag;
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        isSameTreeFlag = true;
        Dfs(p, q);
        //判斷當前的節點有沒有相同
        return isSameTreeFlag;

    }

    public void Dfs(TreeNode p, TreeNode q)
    {   //base case 
        //兩個都null 算一樣
        if (p == null && q == null) return;
        //一個null 算不一樣            //進行val判斷 修改flag 兩個邏輯一樣 合併寫一起
        if ((p == null || q == null) || (p.val != q.val))
        {
            isSameTreeFlag = false;
            return;
        }

        //看看左子樹
        Dfs(p.left, q.left);
        //如果發現不是平衡樹 提早結束
        if (!isSameTreeFlag) return;
        //看看右子樹
        Dfs(p.right, q.right);
    }
}
