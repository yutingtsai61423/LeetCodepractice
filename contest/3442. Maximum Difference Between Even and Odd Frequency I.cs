public class Solution {
    public int MaxDifference(string s)
    {
        //count freq
        Dictionary<char, int> freq = new Dictionary<char, int>();
        int maxOddCount = int.MinValue;
        int minEvenCount = int.MaxValue;
        foreach (char c in s)
        {
            freq.TryGetValue(c, out int count);//沒有值會是預設值
            freq[c] = ++count;
        }

        foreach (int count in freq.Values)
        {
            if (count % 2 == 0) minEvenCount = Math.Min(minEvenCount, count);
            else maxOddCount = Math.Max(maxOddCount, count);
        }

        return maxOddCount - minEvenCount;
    }
}
