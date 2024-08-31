public class Solution {
    public int GenerateKey(int num1, int num2, int num3)
    {
        StringBuilder key = new StringBuilder();
        string num1str = paddingToString(num1);
        string num2str = paddingToString(num2);
        string num3str = paddingToString(num3);
        int ans;
        for (int i = 0; i < 4; i++)
        {
            int min = Math.Min(num1str[i], Math.Min(num2str[i], num3str[i]));
            key.Append(Convert.ToString((char)min));
            Console.WriteLine($"min = {(char)min}");
            Console.WriteLine($"cur key= {key.ToString()}");
        }

        int.TryParse(key.ToString(), out ans);

        return ans;
    }

    public string paddingToString(int num)
    {
        string tmp = Convert.ToString(num);
        if (tmp.Length < 4) tmp = tmp.PadLeft(4, '0');
        Console.WriteLine($"{num} after padding = {tmp}");
        return tmp;
    }
}
