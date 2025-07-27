public class Solution {
        public long MaximumMedianSum(int[] nums)
        {
            long res = 0;
            //排序
            Array.Sort(nums);

            //每次取第一個配上最後兩個
            //計算
            int right = nums.Length - 1;
            
            for (int left = 0; left <= right-2; left++)
            {
                res += nums[right - 1];
                right -= 2;
            }
            

            return res;
        }
}
