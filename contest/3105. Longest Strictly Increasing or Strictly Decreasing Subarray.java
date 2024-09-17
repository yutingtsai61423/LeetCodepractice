class Solution {
    public int longestMonotonicSubarray(int[] nums) {
        int right = 0;
        int left = 0;
        int lastIndexOfNums = nums.length -1;
        int max = 1;
        
        while (right < lastIndexOfNums) { //檢查right走到底了嗎
            //只有一個的時候檢查是否不相等，若不相等加進來，若相等就不能加進來，要跳找下一個數字開頭
            // System.out.printf("現在指針left= %d right=%d \n", left, right);
            if (right == left) {
                // System.out.printf("指針重合 在index=%d \n", right);
                if (nums[right] == nums[right+1]) {
                    right++;
                    left = right;
                    // System.out.printf("最大長度目前是 %d \n", max);
                    // System.out.printf("-------------------\n");
                    continue;
                } else{
                    right++;
                    if ((right - left + 1) > max) { //若長度比最大的長，最大就是現在的長度
                        max = right - left + 1;
                    }                    
                    // System.out.printf("最大長度目前是 %d \n", max);
                    // System.out.printf("-------------------\n");
                    continue;
                }
            }
            
            //有兩個的時候檢查右邊的是否形成遞增或遞減
            if (isIncreaseOrDecrease(nums[right -1 ], nums[right], nums[right+1])){
                right++;
                if ((right - left + 1) > max) { //若長度比最大的長，最大就是現在的長度
                    max = right - left + 1;
                }
            } else { //未形成遞增遞減
                left = right;
            }
            // System.out.printf("最大長度目前是 %d \n", max);
            // System.out.printf("-------------------\n");
        }
        
        return max;
    }
    
    public boolean isIncreaseOrDecrease(int lastTwo, int lastOne, int wantToAddNum){
        // System.out.printf("比較是否遞增減\n");
        if ((lastTwo > lastOne) && (lastOne > wantToAddNum) ){ //判斷為遞減
            // System.out.printf("是遞減\n");
            return true;
        } else if ((lastTwo < lastOne) && (lastOne < wantToAddNum)){ //判斷為遞增
            // System.out.printf("是遞增\n");
            return true;
        } else {
            // System.out.printf("不是遞增或遞減\n");
            return false;
        }
    }
}
