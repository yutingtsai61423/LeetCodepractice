public class Solution {
   public string ConvertDateToBinary(string date)
    {
        StringBuilder res = new StringBuilder();
        Stack<int> stack = new Stack<int>();

        string[] strSplit = date.Split("-");

        int count = 0;
        foreach (string str in strSplit)
        {
            int num = Convert.ToInt32(str);
            while (num != 0)
            {
                stack.Push(num % 2);
                num /= 2;
            }

            while (stack.Count > 0)
            {
                res.Append(stack.Pop());
            }

            if (count < 2) res.Append("-");
            count++;

        }
        return res.ToString();
    }

}
