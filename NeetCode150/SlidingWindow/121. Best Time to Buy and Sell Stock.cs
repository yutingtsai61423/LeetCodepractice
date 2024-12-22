public class Solution {
    public int MaxProfit(int[] prices)
    {
        //找到有利潤的case
        //
        int right = 0;
        int left = 0;
        int res = 0;

        while (right < prices.Length)
        {
            //看看利潤有沒有比較大
            int benefit = prices[right] - prices[left];
            if (benefit > res) //利潤變大 更新利潤
                res = benefit;
            else if (benefit < 0) //找到更低的left
                left = right;
            right++;
        }
        return res;
    }
}
