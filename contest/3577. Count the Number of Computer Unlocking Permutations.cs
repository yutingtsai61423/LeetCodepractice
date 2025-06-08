public class Solution {
public int CountPermutations(int[] complexity)
{
    int MOD = 1000000007;
    int n = complexity.Length;

    // 檢查是否所有後面的數都大於第一個數
    for (int i = 1; i < n; ++i)
    {
        if (!(complexity[i] > complexity[0]))
            return 0;
    }

    // 計算 (n - 1)! % MOD
    long res = 1;
    for (int i = 1; i <= n - 1; ++i)
    {
        res = (res * i) % MOD;
    }

    return (int)res;
}

}
