public class Solution {
    public string FindValidPair(string s)
    {
        //計算每個數字出現的次數
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach (char c in s)
        {
            // int cToint = c - '0';
            freq.TryGetValue(c, out int count);
            freq[c] = ++count;
        }

        for (int right = 1; right < s.Length; right++)
        {
            int left = right - 1;
            if (s[left] == s[right]) continue;
            if (s[left] - '0' == freq[s[left]]
                && s[right] - '0' == freq[s[right]]) return s.Substring(left, 2);
        }
        return "";
    }
}
