class Solution {
    public int minimumSubarrayLength(int[] nums, int k) {
        for (int i = 1; i <= nums.length; i++){
            for(int j = 0; j < nums.length - i +1; j++){
                int orResult = nums[j];
                int count = 0; //要OR i 次
                while (count <i){
                    orResult |= nums[j+count];
                    System.out.println("[cut length= " + i + "do " + nums[j] +" | " +  nums[j+count] + "result = " + orResult );
                    count++;
                }
                
                if(orResult >= k){
                    return i;
                } else {
                    System.out.println( orResult +" < "+ k);
                }
                
            }
        }
        
        return -1;
        
    }
}
