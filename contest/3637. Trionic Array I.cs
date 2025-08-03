public class Solution {
        public bool IsTrionic(int[] nums)
        {
            bool firstIncrease = false;
            bool decrease = false;
            bool increase = false;

            for (int p = 1; p < nums.Length - 2; p++)
            {
                firstIncrease = nums[p - 1] < nums[p];
                if (firstIncrease)
                {
                    for (int q = p + 1; q < nums.Length - 1; q++)
                    {
                        decrease = nums[q - 1] > nums[q];
                        if (decrease)
                        {
                            
                            for (int n = q + 1; n < nums.Length; n++)
                            {
                                increase = nums[n - 1] < nums[n];
                                if (increase && n == nums.Length - 1)
                                    return true;

                                if (increase)
                                    continue;
                                else
                                    break;
                                    
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                }
                else
                {
                    break;
                }

            }

            return firstIncrease && decrease && increase;
        }
}
