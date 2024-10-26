public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> res = new Dictionary<string, IList<string>>();

        foreach (string s in strs)
        {
            //計算字串中的字元出現頻率，當成dicitonary的key，value則是字串
            int[] count = new int[26];//會被初始化為0
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a'] += 1;
            }

            string freqKey = string.Join(",", count);
            if (res.TryGetValue(freqKey, out IList<string> sameStr)) sameStr.Add(s);
            else res[freqKey] = new List<string>{s};

        }

        

        return res.Values.ToList();
    }
}
