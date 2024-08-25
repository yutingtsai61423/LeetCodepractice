public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        for (int i = 0; i < k; i++)
        {
            int[] copy = new int[nums.Length];
            Array.Copy(nums, copy, nums.Length);
            Array.Sort(copy);
            int min = copy[0];
            int firstIndex = Array.FindIndex(nums, e => e == min);
            nums[firstIndex] = min * multiplier;

            // Array.ForEach(nums, num => Console.WriteLine(num));
            // Console.WriteLine("----------");

        }

        return nums;
    }
}
