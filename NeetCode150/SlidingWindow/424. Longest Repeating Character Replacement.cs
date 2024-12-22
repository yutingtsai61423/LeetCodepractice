public class Solution {
   public int CharacterReplacement(string s, int k)
    {
        //ABABBA 
        //找滿足條件的最長子字串：出現頻率較低的的字母，數量小於等於k
        //找最長 所以用左右指針夾出的範圍就是 window
        Dictionary<char, int> freq = new Dictionary<char, int>();

        int right = 0;
        int left = 0;
        int res = 0;
        int maxFreq = 0;
        while (right < s.Length)
        {
            int curLen = right - left + 1;
            //更新頻率
            freq[s[right]] = freq.TryGetValue(s[right], out int tmp) ? tmp + 1 : 1;

            //更新目前最大的頻率
            maxFreq = freq.Values.Max();

            //檢核子字串是否合規：出現頻率較低的的字母，數量小於等於k
            //出現頻率較低的字母的數量：全部的數量-出現頻率比較高的數量
            if (curLen - maxFreq <= k) //字串合規
            {
                if (curLen > res) res = curLen;
            }
            else //字串不合規
            {
                freq[s[left]] -= 1;
                left++;
                //freq[s[left]] = freq.TryGetValue(s[left], out int tmp2) ? tmp2 + 1 : 1;
            }

            right++;
        }

        return res;
    }

}
