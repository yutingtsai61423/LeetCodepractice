public class Solution {
   public char KthCharacter(int k)
    {
        //用loop append 字
        //字超過z要轉回a

        int[] arrStr = new int[k];
        arrStr[0] = 'a';

        int curLenth = 1;
        while (curLenth < k)
        {
            for (int i = 0; i < curLenth && i + curLenth < k; i++)
            {
                int cur = arrStr[i] + 1;
                arrStr[i + curLenth] = cur > 'z' ? cur - 'a' : cur;

                // Console.WriteLine($"curChar [{i}]= {arrStr[i]} newChar [{i + curLenth}] = {arrStr[i + curLenth]}");
            }

            curLenth *= 2;
        }

        return (char)arrStr[k - 1];
    }

}
