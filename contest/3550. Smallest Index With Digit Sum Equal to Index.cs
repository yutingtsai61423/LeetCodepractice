public class Solution {
        public int SmallestIndex(int[] nums)
        {
            int res = -1;

            //加總
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                int num = nums[i];
                while (num > 0)
                {
                    sum += num % 10;
                    num /=  10;
                }

                if (sum == i) return i;
            }

            return res;
        }
}
