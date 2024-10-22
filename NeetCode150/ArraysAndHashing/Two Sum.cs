public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        //遍歷Nums一次 陸續加入元素 
        //如果要找A+B 走到A的時候 MAP還沒有B 走到B的時候，MAP裡面一定會有A
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            //取要尋找的數
            int toFind = target - nums[i];
            if (dict.TryGetValue(toFind, out int indexFind))
            {
                return new int[] { i, indexFind };
            }
            else
            {
                dict[nums[i]] = i;
            }
        }
        return null;
    }
}
