public class Solution {
    public int Search(int[] nums, int target) {
       int left = 0;
        int right = nums.Length-1;

        while (left <= right)
        {
            int find = left +  ((right - left) / 2);
            if (target < nums[find])
            {
                //情況1=目標在左邊
                right = find - 1; //少一步，因為當下步已經判斷過了
            }
            else if (nums[find] < target)
            {
                //情況2=目標在右邊
                left = find + 1;
            }
            else
            {
                //情況3=目標找到了
                return find;
            }
        }
        //情況4=目標不在這裡
        return -1;
    }
}
