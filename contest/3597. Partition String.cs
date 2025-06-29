public class Solution {
       public IList<string> PartitionString(string s)
       {
           HashSet<string> set = new HashSet<string>();
           IList<string> res = new List<string>();
           StringBuilder tmp = new StringBuilder();
           string current = "";
           foreach (char c in s)
           {
               current = tmp.ToString() + c.ToString();
               if (set.Add(current)) //沒看過
               {
                   res.Add(current);
                   tmp.Clear();
               }
               else //有看過
               {
                   tmp.Append(c);
               }
           }
           return res;
       }
}
