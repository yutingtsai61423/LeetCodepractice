public class Solution {
    public int maximumLength(int[] nums) {
        // 檢查第一個數是否為奇數
        boolean firstOdd = nums[0] % 2 == 1;

        // 初始化長度變量
        int OOLen = firstOdd ? 1 : 0;  // 初始奇數序列長度
        int EELen = firstOdd ? 0 : 1;  // 初始偶數序列長度
        int OELen = firstOdd ? 1 : 0;  // 初始奇偶交替序列長度
        int EOLen = firstOdd ? 0 : 1;  // 初始偶奇交替序列長度

        // 初始化結果變量
        int res = 1;

        // 遍歷數組從第二個元素開始
        for (int i = 1; i < nums.length; ++i) {
            int num = nums[i];
            boolean odd = num % 2 == 1;
            boolean even = !odd;

            if (odd) {
                // 當前數為奇數時
                OOLen++;  // 增加奇數序列長度

                if (OELen % 2 == 1) {
                    // 如果奇偶交替序列長度為奇數，保持長度不變
                } else {
                    // 如果奇偶交替序列長度為偶數，增加長度
                    ++OELen;
                }

                if (EOLen % 2 == 0) {
                    // 如果偶奇交替序列長度為偶數，保持長度不變
                } else {
                    // 如果偶奇交替序列長度為奇數，增加長度
                    ++EOLen;
                }
            } else {
                // 當前數為偶數時
                EELen++;  // 增加偶數序列長度

                if (OELen % 2 == 1) {
                    // 如果奇偶交替序列長度為奇數，增加長度
                    OELen++;
                } else {
                    // 如果奇偶交替序列長度為偶數，保持長度不變
                }

                if (EOLen % 2 == 0) {
                    // 如果偶奇交替序列長度為偶數，增加長度
                    EOLen++;
                } else {
                    // 如果偶奇交替序列長度為奇數，保持長度不變
                }
            }
        }

        // 返回最大序列長度
        return Math.max(Math.max(OOLen, EELen), Math.max(OELen, EOLen));
    }
}
