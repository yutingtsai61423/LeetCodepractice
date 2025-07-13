public class Solution {
        public string ProcessStr(string s)
        {

            List<char> res = new List<char>();
            foreach (char c in s)
            {
                if ('*' == c)
                {
                    if (res.Count > 0)
                    res.RemoveAt(res.Count - 1);
                }
                else if ('%' == c)
                {
                    res.Reverse();
                }
                else if ('#' == c)
                {
                    res.AddRange(new List<char>(res));
                }
                else
                {
                    res.Add(c);
                }
            }

            return new string(res.ToArray());
        }
}
