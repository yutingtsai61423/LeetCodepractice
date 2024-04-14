class Solution {
    public int maximumPrimeDifference(int[] nums) {
        //找出質數 -> index另存arr -> 找arr中最大-最小
    
        //列出0~100的質數表 1不是質數 
        boolean[] primeArray = new boolean[101];
        
        for (int i = 2; i <= 100; i++) {
            if (isPrime(i)) {
                primeArray[i] = true;
            }
        }
        
        List<Integer> indexList = new ArrayList<>();
        int index = 0;
        for (int num : nums) {
            if (primeArray[num] == true) {
                indexList.add(index);
            }
            index++;
        }
        
        indexList.sort(Comparator.naturalOrder());
        return indexList.get(indexList.size()-1) - indexList.get(0);
            
    }
    
    
    
    boolean isPrime(int num){
        double sqrt = Math.sqrt(num);
        int divide = 2;      
        
        while (divide <= sqrt){
            if ((num % divide) == 0 ){
                return false;
            }
            divide++;
        }
        return true;
    }
}
