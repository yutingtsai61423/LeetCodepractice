/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public List<String> binaryTreePaths(TreeNode root) {
        List<String> list = new ArrayList<String>();
        if(root == null){
            return null;
        }
        
        String str = "";
        //List<String> forAnswer = find(root, str, list);
        find(root, str, list);
        return list;
        
    }
    
    public void find(TreeNode node, String str, List<String> list){  // path = "1"

        if (node.left == null && node.right == null){
            list.add(str+ node.val);
            System.out.println("str in null= " + str);
        }
        
        if (node.left != null){
            System.out.println("str in left= " + str);
            find(node.left, str + node.val +"->", list);
        }
               
        //有子孫 所以把自己寫入字串
        if (node.right != null){
            System.out.println("str in right= " + str);
            find(node.right, str + node.val +"->", list);
        }
    }
}
