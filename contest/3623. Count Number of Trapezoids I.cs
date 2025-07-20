public class Solution {
        public int CountTrapezoids(int[][] points)
        {
            int _1000000007 = 1000000007;
            long result = 0;

            Dictionary<int, int> howManyX = new Dictionary<int, int>();

            foreach (int[] xy in points)
            {
                int x = xy[0];
                int y = xy[1];

                howManyX.TryGetValue(y, out int count);
                howManyX[y] = count + 1;
            }

            List<long> howManyXCombination = new List<long>();

            foreach (KeyValuePair<int, int> kvpair in howManyX)
            {
                int y = kvpair.Key;
                int count = kvpair.Value % _1000000007;
                long combination = ((long)count * (count - 1) / 2) % _1000000007;

                howManyXCombination.Add(combination);
            }

            long preSum = 0;

            foreach (long cur in howManyXCombination)
            {
                result = (result + cur * preSum % _1000000007) % _1000000007;
                preSum = (preSum + cur) % _1000000007;
            }

            return (int)result;
        }
}
