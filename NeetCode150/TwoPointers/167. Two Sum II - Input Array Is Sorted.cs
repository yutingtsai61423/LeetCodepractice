public class Solution {
    public int[] TwoSum(int[] numbers, int target)
    {
        //因為加起來要等於target，數列已排序，因此用two pointer先指向最兩端的值，
        //加起來如果太大，表示right index要向左一步(數字變小)
        //加起來如果太小，表示left index 要向右一步(數字變大)

        int right = numbers.Length - 1;
        int left = 0;
        int sum = 0;
        while (true)
        {
            sum = numbers[right] + numbers[left];

            if (sum > target) right--;
            else if (sum < target) left++;
            else break;
        }

        return new int[]{left+1, right+1};
    }
}
