public class Solution {
    public int[] GetSneakyNumbers(int[] nums)
    {
        //做一個BOOL列表
        //檢查是否是TRUE
        //  若TURE 記在result
        //  else FALSE便TRUE

        bool[] tmp = new bool[nums.Length - 2]; //有預設值
        List<int> result = new();

        foreach (int num in nums)
        {
            if (tmp[num] == true) result.Add(num);
            else tmp[num] = true;
        }
        
        return result.ToArray();
    }
}
