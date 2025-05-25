public class Solution {
        public string ResultingString(string s)
        {
            if (s.Length == 1)
                return s;

            StringBuilder sb = new StringBuilder(s);

            int left = 0;
            int right = 1;

            while (right < sb.Length)
            {
                //check
                if (Math.Abs(sb[left] - sb[right]) == 1  || Math.Abs(sb[left] - sb[right]) == 25)
                {
                    sb.Remove(left, 2);//1 2

                    if (left > 0)
                    {
                        left -= 1;
                        right -= 1;
                        continue;
                    } 
                }
                else
                {
                    right++;
                    left++;
                    continue;
                } 
            }

            return sb.ToString();
        }
}
