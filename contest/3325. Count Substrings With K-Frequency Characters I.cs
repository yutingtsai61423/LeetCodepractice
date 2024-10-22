public class Solution {
    public int NumberOfSubstrings(string s, int k)
    {
        //twopointer找找
        int left = 0;
        int res = 0;
        while (left < s.Length)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int right = left; right < s.Length; right++)
            {
                // Console.WriteLine("----");
                //維護字元出現頻率
                dic.TryGetValue(s[right], out int freq);
                dic[s[right]] = ++freq;

                // foreach (KeyValuePair<char, int> pair in dic)
                // {
                //     Console.Write(pair.Key + " " + pair.Value);
                //     Console.WriteLine("");
                // }

                if (freq >= k)
                {
                    //如果滿足了 就把後面字元的長度結算成數量 right不用走到最後
                    res += s.Length - right;
                    // Console.WriteLine("freq >= k, break");
                    break;
                }
            }
            // dic.TryGetValue(s[left], out int freqLeft);
            // dic[s[left]] = --freqLeft;
            left++;
            // Console.WriteLine($"move left to {left}");
        }

        return res;
    }
}
