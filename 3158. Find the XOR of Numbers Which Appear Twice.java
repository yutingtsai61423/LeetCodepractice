class Solution {
    public int duplicateNumbersXOR(int[] nums) {
        Set<Integer> recordNum = new HashSet<>();
        Set<Integer> repeatNums = new HashSet<>();
        
        for (int i : nums){
            if (!recordNum.add(Integer.valueOf(i))){
                repeatNums.add(Integer.valueOf(i));
            }
        }
        
        int sum = 0;
        for (Integer i : repeatNums) {
            sum = sum ^ i;
        }
        
        return sum;
    }
}
