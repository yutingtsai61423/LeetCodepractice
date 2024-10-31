public class Solution {
    public bool IsPalindrome(string s)
    {
        //用左右指針來看字串(就不用空間再放一個 排除標點空白的新字串 和倒序的新字串)
        int left = 0;
        int right = s.Length - 1;
        //當還沒到一半
        while (left < right)
        {
            while (!isAlphaNum(s[left]) && left < right)
            {
                left++;
            }
            while (!isAlphaNum(s[right]) && left < right)
            {
                right--;
            }
            // Console.WriteLine($"left={left} right={right}");
            // Console.WriteLine($"s[left]={s[left]} s[right]={s[right]}");

            if (char.ToLower(s[left]) != char.ToLower(s[right])) return false;

            left++;
            right--;
        }
        return true;
    }

    //實作是否為字母
    public bool isAlphaNum(char c)
    {
        if ('a' <= c && c <= 'z' ||
            'A' <= c && c <= 'Z' ||
            '0' <= c && c <= '9')
            return true;
        else
            return false;
    }
}
