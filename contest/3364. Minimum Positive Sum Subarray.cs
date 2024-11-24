public class Solution {
    public int MinimumSumSubarray(IList<int> nums, int l, int r)
    {
        //
        int res = -1;
        int min = int.MaxValue;
        // ((List<int>)nums).Sort();
        //左指針按照順序走
        for (int left = 0; left < nums.Count; left++)
        {
            // Console.WriteLine("===============");
            int right = left;
            int subArraySum = nums[left];
            // Console.WriteLine($"current left = {left}");
            //右指針走到指定的最小subArray長度
            while ((right - left + 1) < l && (right < nums.Count))
            {
                right++;
                // Console.WriteLine($"right++ ,right = {right}");
                if (right < nums.Count) subArraySum += nums[right];

                // Console.WriteLine($"current subArraySum = {subArraySum}");
            }
            //在合理的index範圍中檢查總和
            while ((right - left + 1 <= r) && (right < nums.Count))
            {
                if (subArraySum > 0)
                {
                    min = Math.Min(subArraySum, min);
                    // Console.WriteLine($" min = {min}");
                    res = min;
                }
                right++;
                if (right < nums.Count) subArraySum += nums[right];
                // Console.WriteLine("---next right-----");
            }
            //結束了就進行下一圈
        }

        return res;
    }
}
