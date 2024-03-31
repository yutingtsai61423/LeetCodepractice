class Solution {
    public int sumOfTheDigitsOfHarshadNumber(int x) {
        //計算每位數字和
        int sumOfDigits = 0;
        
        int digit = x;
        while(digit != 0){
            sumOfDigits += digit % 10 ;
            System.out.printf("digit = %d, sumOfDigits = %d",digit, sumOfDigits );
            digit /= 10 ;
        }
        
        if(x % sumOfDigits == 0){
            return sumOfDigits;
        }
        
        return -1;
        
    }
}
