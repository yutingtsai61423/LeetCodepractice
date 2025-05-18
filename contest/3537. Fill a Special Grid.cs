public class Solution {
       public int[][] SpecialGrid(int N)
       {
           int n = (int)Math.Pow(2, N);// 計算網格的邊長為 2^N
           int total = n * n;// 網格中總共會有 n * n 個數字

           int[][] res = new int[n][];
           for(int i = 0; i < n; i++)
           {
               res[i] = new int[n];
           }
            Dfs(0, n - 1, 0, n - 1, 0, total - 1, res);

           return res;

       }

       public int[][] Dfs(int iStart, int iEnd, int jStart, int jEnd, int numStart, int numEnd, int[][] res)
       {
           if(iStart == iEnd && jStart == jEnd)
           {
               res[iStart][jStart] = numStart;
               return res;
           }
           // 將當前區塊的上下與左右中點算出來（將區塊劃分為四個象限）
           int iMid = iStart + (iEnd - iStart) / 2;
           int jMid = jStart + (jEnd - jStart) / 2;

           // 把當前的數字範圍分成四等份
           int subLen = (numEnd - numStart + 1) / 4;

           // 各象限分配的數字範圍
           int num1Start = numStart;
           int num1End = num1Start + subLen - 1;

           int num2Start = num1End + 1;
           int num2End = num2Start + subLen - 1;

           int num3Start = num2End + 1;
           int num3End = num3Start + subLen - 1;

           int num4Start = num3End + 1;
           int num4End = num4Start + subLen - 1;

           // 遞迴填入四個象限的數字（依照題目條件順序）
           // 右上 < 右下 < 左下 < 左上

           // 1. 填右上象限（最小）
           Dfs(iStart, iMid, jMid + 1, jEnd, num1Start, num1End, res);

           // 2. 填右下象限（第二小）
           Dfs(iMid + 1, iEnd, jMid + 1, jEnd, num2Start, num2End, res);

           // 3. 填左下象限（第三小）
           Dfs(iMid + 1, iEnd, jStart, jMid, num3Start, num3End, res);

           // 4. 填左上象限（最大）
           Dfs(iStart, iMid, jStart, jMid, num4Start, num4End, res);

           return res;
       }

}
