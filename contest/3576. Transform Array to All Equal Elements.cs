public class Solution {
        public bool CanMakeEqual(int[] nums, int k)
        {
            int negativeCount = nums.Count( n => n == -1);
            int positiveCount = nums.Length - negativeCount;

            bool negativeIsEven = negativeCount % 2 == 0;
            bool positiveIsEven = positiveCount % 2 == 0;


            //要有偶數個
            if (!negativeIsEven && !positiveIsEven)
                return false;

            //數量多 距離遠 都會影響結果 所以+-直接算再比較

            List<int> indeies = new List<int>();
            int resCount = 0;
            
            if (negativeIsEven)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == -1)
                        indeies.Add(i);
                }

                for (int i = 0; i + 1 < indeies.Count; i += 2)
                {
                    resCount += (indeies[i + 1]  - indeies[i]);
                }

                if (resCount <= k) return true;
            }
            //找index

            int resCountPos = 0;
            List<int> indeiesPositive = new List<int>();
            if (positiveIsEven)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 1)
                        indeiesPositive.Add(i);
                }

                for (int i = 0; i + 1 < indeiesPositive.Count; i += 2)
                {
                    resCountPos += (indeiesPositive[i + 1] - indeiesPositive[i]);
                }


                if (resCountPos <= k) return true;
            }

            return false;
        }
}
