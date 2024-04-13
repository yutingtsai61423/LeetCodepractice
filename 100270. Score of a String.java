class Solution {
    public int scoreOfString(String s) {
        int sum = 0;
        char[] sArr = s.toCharArray();
        //兩個相減
        for (int i = 0; i < s.length()-1; i++){
            sum += Math.abs(sArr[i] - sArr[i+1]);
            System.out.println("sum = " + sum);
        }
         return sum;
        
    }
}
