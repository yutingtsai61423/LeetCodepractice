class Solution {
    public String losingPlayer(int x, int y) {
        //找出bottle neck 小的是bottleneck
        
        int num75 = x;
        int num10 = y/4;
        
        int bottleNeck = Math.min(num75, num10);
        if (bottleNeck % 2 == 1){
            return "Alice";
        } else {
            return "Bob";
        }
    }
}
