class Solution {
 public int minFlips(int[][] grid) {
        int m = grid.length, n = grid[0].length;
        int h = 0, v = 0;

        // 計算水平翻轉次數
        for (int r = 0; r < m; ++r) {
            int i = 0;
            int j = n - 1;
            while (i < j) {
                if (grid[r][i++] != grid[r][j--]) {
                    ++h;
                }
            }
        }

        // 計算垂直翻轉次數
        for (int c = 0; c < n; ++c) {
            int i = 0;
            int j = m - 1;
            while (i < j) {
                if (grid[i++][c] != grid[j--][c]) {
                    ++v;
                }
            }
        }

        // 返回水平翻轉和垂直翻轉的最小值
        return Math.min(h, v);
    }
}
