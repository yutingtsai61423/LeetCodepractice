public class Solution {
       public bool HasSameDigits(string s)
       {
           bool res = Dfs(s);

           return res;
       }

       public bool Dfs(string s)
       {
           if (s.Length == 2) return s[0] == s[1];

           s = GetStr(s);

           return Dfs(s);
       }

       public string GetStr(string s)
       {
           StringBuilder str = new StringBuilder();
           for (int i = 0; i + 1 < s.Length; i++)
           {
               int fore = s[i] - '0';
               int back = s[i + 1] - '0';

               int tmp = (fore + back) % 10;
               str.Append(tmp);
           }
           return str.ToString();
       }

}
