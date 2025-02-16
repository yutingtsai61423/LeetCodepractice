public class Solution {
    public bool HasSpecialSubstring(string s, int k) //s = "ababaaa", k = 3
    {
        //開window
        bool status = false;
        int l = 0;
        int r = 0;
        Dictionary<char, int> freq = new Dictionary<char, int>();
        while (r < k)
        {
            char cur = s[r];
            freq.TryGetValue(cur, out int count);
            freq[cur] = ++count;
            r++;
        }

        foreach (int count in freq.Values)
        {
            if (r < s.Length && s[r] == s[r - 1]) break;
            if (count == k) status = true;
        }

        while (r < s.Length)
        {
            if (status == true) return true;

            //maintain right
            char curR = s[r];
            freq.TryGetValue(curR, out int countR);
            freq[curR] = ++countR;

            char curL = s[l];
            freq[curL] -= 1;

            l++;

            bool isHeadEndPass = true;
            if ((l > 0 && s[l] == s[l - 1])
                || (r + 1 < s.Length && s[r] == s[r + 1])) isHeadEndPass = false;

            status = (freq[s[l]] == k) && isHeadEndPass;

            r++;
        }

        return status;

    }
}
