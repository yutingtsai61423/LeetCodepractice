public class Solution {
    public IList<IList<int>> Permute(int[] nums)
    {
        if (nums.Length == 0) return new List<IList<int>> { new List<int>() };
        //從base case開始，每要加入一個數字，就插入在不同的間隙中，獲得所有的排列組合

        IList<IList<int>> tempRes = Permute(nums.Skip(1).ToArray());

        IList<IList<int>> res = new List<IList<int>>();
        foreach (IList<int> innerList in tempRes)
        {
            for (int i = 0; i <= innerList.Count; i++)
            {
                // List<int> copyList = innerList.Select(e => e).ToList();
                List<int> copyList = new List<int>(innerList);
                copyList.Insert(i, nums[0]);
                res.Add(copyList);
                //把每個排列過的組合，
                //[2, 3] [3, 2] 在不同的index放入1
            }
        }

        return res;
    }

}
