public class Solution {
        public long MinCuttingCost(int n, int m, int k)
        {
            long res = 0;

            //10 5
            while(n > k)
            {
                n -= k;
                res += (n) * (long)k;
            }
            while (m > k)
            {
                m -= k;
                res += (m) * (long)k;
            }

            return res;
        }
}
