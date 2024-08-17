public class Solution
{
    public int[] ResultsArray(int[] nums, int k)
    {
        int[] results = new int[nums.Length - k + 1];
        for (int i = 0; i + k - 1 < nums.Length; i++)
        {
            int[] sub = nums.Skip(i).Take(k).ToArray();

            foreach (int a in sub)
            {
                Console.WriteLine(a);

            }

            Console.WriteLine("---------");

            int ans = FindAscending(sub);
            results[i] = ans;
        }

        return results;

    }

    public int FindAscending(int[] arr)
    {
        for (int i = 0; i + 1 < arr.Length; i++)
        {
            if (arr[i] == arr[i + 1] - 1)
                continue;
            else
                return -1;
        }
        return arr[arr.Length - 1];
    }
}
