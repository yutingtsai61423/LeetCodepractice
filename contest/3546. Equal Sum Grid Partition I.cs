public class Solution {
        public bool CanPartitionGrid(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            // 水平列和與垂直欄和
            long[] rowSums = new long[m];
            long[] colSums = new long[n];

            // 計算每一列與每一欄的總和
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int val = grid[i][j];
                    rowSums[i] += val;
                    colSums[j] += val;
                }
            }

            long totalRowSum = rowSums.Sum();
            long totalColSum = colSums.Sum();

            // 檢查是否能做水平切割
            if (m >= 2)
            {
                long topSum = 0;
                for (int i = 0; i < m - 1; i++)
                {
                    topSum += rowSums[i];
                    long bottomSum = totalRowSum - topSum;
                    if (topSum == bottomSum)
                        return true;
                }
            }

            // 檢查是否能做垂直切割
            if (n >= 2)
            {
                long leftSum = 0;
                for (int j = 0; j < n - 1; j++)
                {
                    leftSum += colSums[j];
                    long rightSum = totalColSum - leftSum;
                    if (leftSum == rightSum)
                        return true;
                }
            }

            return false;
        }
}
