public class Solution {
   public int CountValidSelections(int[] nums)
    {
        int res = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0) continue;
            //從順向找


            int[] copyNums = new int[nums.Length];
            Array.Copy(nums, copyNums, nums.Length);
            if (find(i, 1, copyNums))
            {
                res++;
            }
            Array.Copy(nums, copyNums, nums.Length);
            //從負向找
            if (find(i, -1, copyNums)) res++;
            // Console.WriteLine("\n================");

        }
        return res;
    }

    public bool find(int i, int dir, int[] nums) //假設dir=1
    {

        while (i < nums.Length && i >= 0)
        {
            // Console.WriteLine($"i = {i} num = {nums[i]}");
            // foreach (int num in nums)
            // {
            //     Console.Write(num);
            // }
            // Console.WriteLine("");

            if (nums[i] != 0)
            {
                nums[i] -= 1;
                i -= dir;
                dir *= -1;
            }
            else
            {
                i += dir;
            }

        }
        //超過range就停下來 檢查是否全為0
        foreach (int num in nums)
        {

            // Console.Write(num);
            if (num != 0) return false;
        }

        return true;
    }
}
