public class Solution {
    public int MaxArea(int[] height) {
            int right = height.Length - 1;
        int left = 0;
        int maxArea = 0;
        //當寬固定的時候，面積是小邊決定
        while (left < right)
        {
            int curArea = (right - left) * Math.Min(height[right], height[left]); //寬 * 比較小的高
            maxArea = Math.Max(curArea, maxArea);

            if (height[left] < height[right])//左邊是小邊
            {
                left++;
                continue;
            }
            else
            {
                right--;
            }

        }

        return maxArea;   
    }
}
