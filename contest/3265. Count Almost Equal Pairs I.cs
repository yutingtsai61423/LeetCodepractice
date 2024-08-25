public class Solution {
public int CountPairs(int[] nums)
    {
        int n = nums.Length;
        int res = 0;

        for (int i = 0; i < n; ++i)
        {
            for (int j = i + 1; j < n; ++j)
            {
                int a = nums[i];
                int b = nums[j];
                if (a == b)
                {
                    Console.WriteLine($"{a} {b}");
                    ++res;
                    continue;
                }

                int tmpA = a;
                int tmpB = b;
                List<int> va = new List<int>();
                List<int> vb = new List<int>();

                while (tmpA != 0)
                {
                    va.Add(tmpA % 10);
                    tmpA /= 10;
                }

                while (tmpB != 0)
                {
                    vb.Add(tmpB % 10);
                    tmpB /= 10;
                }

                if (va.Count > vb.Count)
                {
                    List<int> temp = va;
                    va = vb;
                    vb = temp;
                }

                for (int t = va.Count; t < vb.Count; ++t)
                {
                    va.Add(0);
                }

                bool found = false;

                for (int k = 0; k < va.Count && !found; ++k)
                {
                    for (int k2 = k + 1; k2 < va.Count && !found; ++k2)
                    {
                        // Swap va[k] and va[k2]
                        int temp = va[k];
                        va[k] = va[k2];
                        va[k2] = temp;

                        if (va.SequenceEqual(vb))
                        {
                            ++res;
                            found = true;
                        }

                        // Swap back va[k] and va[k2]
                        temp = va[k];
                        va[k] = va[k2];
                        va[k2] = temp;
                    }
                }
            }
        }

        return res;
    }
}
