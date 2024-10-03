public class Solution {

    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {

        /*candidates= [2,3,6,7] target = 7
        暴搜所有組合
            A分支：要再加入一次當前數字 (2可以重複加很多次)
            B分支：不要加入當前的數次，改加 candidates 的下一個
        需要維護
            1. 當下的sum 有沒有>=target
            2. 當下的當下的cur (待放進答案的)
        */

        int sum = 0;
        IList<IList<int>> res = new List<IList<int>>();

        IList<int> cur = new List<int>();

        dfs(0, cur, sum, candidates, target, res);

        return res;

    }

    public void dfs(int i, IList<int> cur, int sum, int[] candidates, int target, IList<IList<int>> res)
    {
        /*base case
            1. sum = taret -> 找到答案 + return;
            2. sum > target -> 此路沒有答案 + return;
        */

        if (sum > target || i >= candidates.Length) return;

        if (sum == target)
        {
            res.Add(new List<int>(cur));
            return;
        }

        cur.Add(candidates[i]);
        sum += candidates[i];
        //左分支 要再加入一次當前數字
        dfs(i, cur, sum, candidates, target, res);

        //右分支 不要加入當前數字 且加入下一格數字
        cur.RemoveAt(cur.Count - 1);
        sum -= candidates[i];
        i += 1;
        dfs(i, cur, sum, candidates, target, res);

    }

}
