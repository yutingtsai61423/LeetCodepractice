public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        //數數量
        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            count.TryGetValue(num, out int freq);
            count[num] = freq + 1;
        }

        //bucketSort
        IList<IList<int>> bucketSort = new List<IList<int>>();
        for (int j = 0; j <= nums.Length; j++)
        {
            bucketSort.Add(new List<int>());
        }

        //把dictionary換成 index = freq, value的list加入數字
        foreach (KeyValuePair<int, int> entry in count)
        {
            IList<int> numbersList = bucketSort[entry.Value];
            if (numbersList == null) numbersList = new List<int> { entry.Key };
            else numbersList.Add(entry.Key);
        }

        List<int> res = new List<int>();
        int i = bucketSort.Count - 1;
        //整理好了 把前 K 大拿出來
        while (res.Count < k && i >= 0)
        {
            bucketSort[i].ToList().ForEach(e => res.Add(e));
            i--;
        }

        return res.ToArray();
    }
}
