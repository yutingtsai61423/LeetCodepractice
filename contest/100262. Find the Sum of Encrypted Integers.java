class Solution {
    public int sumOfEncryptedInt(int[] nums) {
        int sum = 0;
        //判斷幾位數
        for(int num : nums){
            if( num < 10 ) { //個位數
                sum += num;
                continue;
            } else if( num < 100  ){ //十位數
                int ten = num/10;
                int one = num%10;
                if( ten > one ){
                    sum += ten *11;
                } else {
                    sum += one*11;
                }
            } else { //百位 千位
                int[] numSeperate = { (num / 1000) , (num / 100) % 10, (num / 10) % 10, num % 10};
                int max = findMax(numSeperate);
                if(numSeperate[0] == 0){
                    sum += max*111;
                } else {
                    sum += max*1111;
                }
                
            }
                
        }
        return sum;
        
    }
    
    public int findMax(int[] numSeperate){
        int tmp = 0;
        for(int numSep : numSeperate){
            if(numSep > tmp)
            tmp = numSep;
        }
        return tmp;
    }
}
