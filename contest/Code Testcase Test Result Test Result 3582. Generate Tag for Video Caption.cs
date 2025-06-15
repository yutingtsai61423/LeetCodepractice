public class Solution {
        public string GenerateTag(string caption)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("#");


            caption = caption.ToLower();
            int toUpperDiff = 'A' - 'a';

            for (int i = 0; i < caption.Length; i++)
            {
                if (builder.Length >= 100) break;
                //先全部轉小寫
                //看前一個是否為空白 如果是 && 是字母，該字元大寫
                if (    i - 1 >= 0 
                    && caption[i - 1] == ' ' 
                    && (  ('a' <= caption[i] && caption[i] <= 'z') 
                       || ('A' <= caption[i] && caption[i] <= 'Z'))
                    && builder.Length > 1)
                {
                    builder.Append((char)(caption[i] + toUpperDiff));
                    continue;
                }

                if (caption[i] == ' ') continue;

                //其餘都小寫append
                

                builder.Append(caption[i]);

            }    
            return builder.ToString();
        }
}
