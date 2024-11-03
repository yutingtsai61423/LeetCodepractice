public class Solution {
   public bool IsBalanced(string num)
    {
        //sum of odds
        int oddSum = 0;
        for (int i = 1; i < num.Length; i += 2)
        {
            oddSum += num[i] - '0';
            Console.WriteLine($"oddSum += num[i]  oddSum = {oddSum} num[i] = {num[i]}");

        }

        Console.WriteLine("---------");
        int evenSum = 0;
        for (int i = 0; i < num.Length; i += 2)
        {
            evenSum += num[i] - '0';
            Console.WriteLine($"evenSum += num[i]  evenSum = {evenSum} num[i] = {num[i]}");
        }

        if (evenSum == oddSum) return true;
        else return false;
    }
}
