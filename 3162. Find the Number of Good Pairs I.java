class Solution {
    public int numberOfPairs(int[] nums1, int[] nums2, int k) {
       // System.out.print("製作nums2K = ");
        int[] nums2K =  Arrays.stream(nums2)
                            .map(e -> e*k)
                            .toArray();
        
        // System.out.println("------------");
        int count = 0;
        for (int i : nums1) {
            for(int j : nums2K) {
                
                if (i % j == 0) {
                    count++;
                    // System.out.printf("%d 被 %d 整除\n", i, j);
                } else {
                    // System.out.printf("%d 不被 %d 整除\n", i, j);
                }
            }
        }
        
        return count;
    }
    
}
