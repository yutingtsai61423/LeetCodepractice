class Solution {
    public boolean canAliceWin(int[] nums) {
        //加總十位數和各為數
    	int singleSum = 0;
    	int doubleSum = 0;
    	
    	for(int num : nums) {
    		if(num / 10 > 0) {
    			doubleSum += num;
    		} else {
    			singleSum += num;
    		}
    	}
    	
    	return singleSum == doubleSum ? false : true;
    }
}
