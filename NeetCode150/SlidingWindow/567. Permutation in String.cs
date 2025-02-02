public class Solution {
public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        Dictionary<char, int> s1Freq = new Dictionary<char, int>();
        Dictionary<char, int> s2Freq = new Dictionary<char, int>();
        //init 到window的大小
        for (char c = 'a'; c <= 'z'; c++)
        {
            s1Freq.Add(c, 0);
            s2Freq.Add(c, 0);
        }

        int matches = 26;
        foreach (char c in s1)
        {
            s1Freq[c] += 1;
        }

        for (int i = 0; i < s1.Length; i++)
        {
            s2Freq[s2[i]] += 1;

        }

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (s1Freq[c] != s2Freq[c]) matches--;
        }

        //iterate

        int l = 0;
        for (int r = s1.Length; r < s2.Length; r++)
        {
            //先看看是否全符合了
            if (matches == 26) return true;
            //沒符合就來更新dic
            char rightChar = s2[r];
            char leftChar = s2[l];
            s2Freq[rightChar] += 1;
            //若更新前數量不同，更新後數量也不同 -> matches沒改變
            //若更新前數量相同，更新後數量也相同   -> matches沒改變
            //若更新前數量不同，但更新後數量相同 -> matches++
            if (s2Freq[rightChar] == s1Freq[rightChar]) matches++;
            //若更新前數量相同，但更新後數量不同， -> matches--
            else if (s2Freq[rightChar] - 1 == s1Freq[rightChar]
                && s2Freq[rightChar] != s1Freq[rightChar]) matches--;

            s2Freq[leftChar] -= 1;
            //若更新前數量相同，更新後數量相同 -> matches 不變
            //若更新前數量不同，更新後數量不同 -> matches 不變
            //若更新前數量不同，更新後數量相同 -> matches++
            if (s2Freq[leftChar] == s1Freq[leftChar]) matches++;
            //若更新前數量相同，更新後數量不同 -> matches--
            else if (s2Freq[leftChar] + 1 == s1Freq[leftChar]
                && s2Freq[leftChar] != s1Freq[leftChar]) matches--;
            l++;
        }
        return matches == 26;
    }
}
