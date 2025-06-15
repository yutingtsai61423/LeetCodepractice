public class Solution {
    const int MOD = 1_000_000_007;

    public int SpecialTriplets(int[] nums)
    {
        int n = nums.Length;

        // 記錄左側符合條件的數量
        Dictionary<int, int> mapLeft = new();
        int[] vLeft = new int[n];

        // 左到右掃描
        for (int i = 0; i < n; i++)
        {
            int x = nums[i];

            // 檢查在左側有幾個 "2 * x"，可以構成 triplet 的前半段
            if (i > 0)
            {
                if (mapLeft.TryGetValue(x * 2, out int count))
                {
                    vLeft[i] += count;
                }
            }

            // 將目前數字加入左側統計表
            if (!mapLeft.ContainsKey(x)) mapLeft[x] = 0;
            mapLeft[x]++;
        }

        // 記錄右側符合條件的數量
        Dictionary<int, int> mapRight = new();
        int[] vRight = new int[n];

        // 右到左掃描
        for (int i = n - 1; i >= 0; i--)
        {
            int x = nums[i];

            // 檢查在右側有幾個 "2 * x"，可以構成 triplet 的後半段
            if (i < n - 1)
            {
                if (mapRight.TryGetValue(x * 2, out int count))
                {
                    vRight[i] += count;
                }
            }

            // 將目前數字加入右側統計表
            if (!mapRight.ContainsKey(x)) mapRight[x] = 0;
            mapRight[x]++;
        }

        long res = 0;

        // 對所有可能當作中間元素的位置做計算
        for (int i = 1; i < n - 1; i++)
        {
            // 左邊有幾個可當頭，右邊有幾個可當尾，乘起來就是該位置能組成幾組
            res += (long)vLeft[i] * vRight[i];
            res %= MOD; // 模 10^9 + 7，避免溢位
        }

        return (int)res;
    }
}
