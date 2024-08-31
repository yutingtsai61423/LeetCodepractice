public class Solution {
    public string StringHash(string s, int k)
    {
        StringBuilder result = new StringBuilder();
        int repeatTimes = s.Length / k;
        for (int i = 0; i < repeatTimes; i++)
        {
            result.Append(getHash(s.Substring(i * k, k)));//0 1 2 3 4 5
        }
        return result.ToString();
    }

    public string getHash(string subS)
    {
        int count = 0;
        int sum = 0;
        while (count < subS.Length)
        {
            sum += subS[count] - 'a';
            count++;
        }

        char ans = (char)((sum % 26) + 'a');
        Console.WriteLine($"getHash={ans}");
        return ans.ToString();
    }
}
