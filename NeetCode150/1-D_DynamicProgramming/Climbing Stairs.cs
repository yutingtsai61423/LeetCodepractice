public class Solution {
    public int ClimbStairs(int n) {
                if (n == 1) return 1;//走到第一階共有1種方式
        if (n == 2) return 2;//走到第二階共有2種方式

        //走到第3階的方法 = 走到第1階，再跨兩步可到 或 走到第2階，再跨一步可到
        //所以走到第3階的方法數 = 走到第一階的方法數 + 走到第二階的方法數
        int prepre = 1;  //走到n的前兩階方法數 初始化為 走到第一階的方法數
        int pre = 2;     //走道n的前一階方法數 初始化為 走到第二階的方法數   

        int cur = 0;
        for (int i = 3; i <= n; i++)
        {
            cur = prepre + pre; //3
            prepre = pre;
            pre = cur;
        }
        return cur;
    }
}
