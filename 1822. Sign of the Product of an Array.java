class Solution {
    public int arraySign(int[] nums) {
        long product = 1;
        for (int n : nums) {
            if(n > 0) {
                product *= 1;
            } else if (n < 0 ) {
                product *= -1;
            } else {
                product *= 0;
            }
        }
        return this.signFun(product);
    }
    
    public int signFun(long n) {
        if (n > 0) {
            return 1;
        } else if (n < 0) {
            return -1;
        } else {
            return 0;
        }
    }
}
