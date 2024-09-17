class Solution {
    public int valueAfterKSeconds(int n, int k) {
        // 定義常量 MOD，表示 10^9 + 7，用於取模運算
        final int MOD = 1000000007;

        // 創建大小為 n 的數組 v，並初始化所有元素為 1
        int[] v = new int[n];
        for (int i = 0; i < n; ++i) {
            v[i] = 1;
        }

        // 執行 k 次更新操作
        for (int i = 0; i < k; ++i) {
            for (int j = 1; j < n; ++j) {
                // 將 v[j] 更新為 v[j - 1] 和 v[j] 的和，並取模 MOD
                v[j] = (v[j - 1] + v[j]) % MOD ;
            }
        }

        // 返回 v 的最後一個元素，即 v[n - 1]
        return v[n - 1] ;
    
    }
}
