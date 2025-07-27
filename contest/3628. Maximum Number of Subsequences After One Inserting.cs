public class Solution {
        public long NumOfSubsequences(string s)
        {
            long res = 0;
            List<long> prefixLCount = new List<long>();
            List<bool> isC = new List<bool>();
            List<long> suffixTCount = new List<long>(s.Length);


            for (int i = 0; i < s.Length; i++)
            {
                suffixTCount.Add(0); // 預設填入 0
            }
            long tmpL = 0;
            foreach (var c in s)
            {
                //計算 cur 前有幾個L
                prefixLCount.Add(tmpL);
                if (c == 'L') tmpL++;
            }

            //計算 cur 是不是 C
            foreach (var c in s)
            {
                if (c == 'C')
                    isC.Add(true);
                else
                    isC.Add(false);
            }

            //計算 cur 後有幾個T
            long tmpT = 0;
            for (int i = s.Length-1; i >= 0; i--)
            {
                suffixTCount[i]=tmpT;
                if (s[i] == 'T') tmpT++;
            }

            List<long> resList = new List<long>();
            long max = 0;
            int maxIndex = 0;
            for (int i = 0; i < s.Length; i ++)
            {
                if (isC[i] == true)
                {
                    long amount = prefixLCount[i] * suffixTCount[i];
                    if (amount > max)
                    {
                        max = amount;
                        maxIndex = i;
                    }
                    resList.Add(amount);
                }
            }

            long resSum = resList.Sum();

            //加上之後試試看哪一個會獲得最大值

            //L加在最左會獲得最大值
            long addLmax = 0 ;
            for(int i = 0; i < s.Length; i++)
            {
               if(isC[i] == true)
                {
                    addLmax += (prefixLCount[i] + 1) * suffixTCount[i];
                }
            }

            //C在每個位置加加看
            long addCmax = 0;
            for (int i = 1; i < s.Length; i++)
            {
                //if (isC[i] == true)
                //{
                long tmpCSum = (prefixLCount[i]) * (suffixTCount[i - 1]) + resSum;
                addCmax = Math.Max(addCmax, tmpCSum);
                //}
            }


            //T加在最右會獲得最大值
            long addTmax = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (isC[i] == true)
                {
                    addTmax += (prefixLCount[i]) * (suffixTCount[i] + 1);
                }
            }


            return Math.Max(addLmax, Math.Max(addCmax, addTmax));
        }
}
