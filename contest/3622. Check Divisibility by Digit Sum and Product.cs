public class Solution {
        public bool CheckDivisibility(int n)
        {
            bool res = false;
            int sum = 0, product = 1; ;

            int tmp = n;
            while (tmp > 0 )
            {
                sum += tmp % 10;
                product *= tmp % 10;
                tmp = tmp / 10;
            }

            if (n % (product + sum) == 0)
                res = true;

            return res;
        }
}
