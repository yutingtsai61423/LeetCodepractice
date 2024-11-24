public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        //給定List 列舉出所有陣列長度=3 && 總和=0 的陣列，列舉出的陣列元素順序沒差，但是兩個陣列內的元素組成不能一樣
        /* 先排序，
           迴圈外層控制第一個數，
           剩下兩個數用twoPointer的方式前後夾擊，找到和第一個數相加=0的兩個數
           因為不可重複，因此twoPointer的Left也不可重複 否則第三個數一定會一樣
           既然left沒有重複，right就也不會重複
        */
        Array.Sort(nums); //nlogn
        IList<IList<int>> res = new List<IList<int>>();

        for (int first = 0; first < nums.Length - 2; first++)
        {
            //first一樣的時候也要跳過
            if (first > 0 && nums[first] == nums[first - 1])
            {
                continue;
            }
            int left = first + 1;
            int right = nums.Length - 1;
            //開始找後兩個數 不可相等，left等於right的時候要停止
            while (left < right)
            {
                int sum = nums[first] + nums[left] + nums[right];
                if (sum > 0) //總和太大，right往左 總和才能變小
                {
                    right--;
                }
                else if (sum < 0) //總和太小 left往右 總和才能變大
                {
                    left++;
                }
                else //總和==0 達標
                {
                    res.Add(new List<int> { nums[first], nums[left], nums[right] });
                    //因為要繼續尋找，left如果很多一樣的值需要跳過，不然會有很多重複項。
                    //當left有跳過重複的 right自然就不會有一樣的值
                    left++;
                    while (nums[left] == nums[left - 1] && left < right)
                    {
                        left++;
                    }

                }
            }

        }
        // foreach (IList<int> list in res)
        // {
        //     PrintList(list);
        // }
        return res;
    }
}
