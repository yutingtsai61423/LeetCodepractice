class Solution {
    public int numberOfChild(int n, int k) {
        int len = n + (n -2);//循環數列的長度
        int i = k % len;
        int maxIndex = n -1;
        return Math.min(i, maxIndex- (i- maxIndex));
        
    }
}
