public class Solution {
        public int MaxProduct(int n)
        {
            int res = int.MinValue;

            int cur = n;
            List<int> list = new List<int>();
            while((cur) > 0)
            {
                list.Add(cur % 10);
                cur /= 10;
            }

            list.Sort();
            res = list[list.Count-1] * list[(list.Count - 2)];

            return res;
        }
}
