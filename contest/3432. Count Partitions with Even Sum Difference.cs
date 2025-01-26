public class Solution {
    public int CountPartitions(int[] nums)
    {
        int res = 0;
        int leftPartitionSum = 0;
        int sum = 0;
        Array.ForEach(nums, e => sum += e);

        for( int i = 0; i < nums.Length -1; i++)
        {
            int num = nums[i];
            sum -= num;
            leftPartitionSum += num;

            if ((leftPartitionSum - sum) % 2 == 0) res++;

        }
        return res;
    }
}
