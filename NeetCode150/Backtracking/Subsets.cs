public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
       /*列舉一個set可以拆分成有多少個小set
            [1, 2, 3, 4]
            數量= 每個元素可以選要加或不加 = 2 * 2 * 2 * 2 = 2^n (n是參與的元素數量)
        */
        IList<IList<int>> res = new List<IList<int>>();
        IList<int> cur = new List<int>();

        dfs(0, nums, cur, res);
        return res;


    }

    public void dfs(int i, int[] nums, IList<int> cur, IList<IList<int>> res)
    {
        //遞迴要寫base case -> 自己的寫法：先順著寫 最後記得補上baseCase
        if (i >= nums.Length)
        {
            res.Add(new List<int>(cur));
            return;
        }
        //決定要不要加num[i]這個元素到set裡面
        cur.Add(nums[i]);//走左子節點
        dfs(i + 1, nums, cur, res);//往左的下走

        cur.RemoveAt(cur.Count - 1);//走右子節點
        dfs(i + 1, nums, cur, res);//往右的下走


    }
}
