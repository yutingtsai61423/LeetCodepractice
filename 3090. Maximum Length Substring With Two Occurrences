class Solution {
    public int maximumLengthSubstring(String s) {
        int[] sLengths = new int[s.length()];
        for (int i = 0; i < s.length(); i++){
             sLengths[i] = findMaxLength(i, s);
            System.out.println("sLengths[i]=" + sLengths[i]);
        }
        
        //計算哪個數字最大
        return Arrays.stream(sLengths).max().orElse(0);
    }
    
    //給定index 從該index開始往後開始搜尋符合每個字元最多重複兩次的最長字串 的長度
    public int findMaxLength(int indexStart,  String s){
        int[] charRepeatCount = new int[26];
        
        //把字串的每個字都計數寫進 charRepeatCount
        for(int i = indexStart; i < s.length(); i++){
            char word = s.charAt(i);
            int charASCII = word;

            charRepeatCount[(charASCII-97)] += 1;
            //若已是2 就代表是最多容納的值了 不能再加
            System.out.println("char = " + word +  " repeat " + charRepeatCount[charASCII-97]);
            if(charRepeatCount[charASCII-97] > 2 ){
                return i-indexStart;  //走到i會爆 所以長度是i-起始的index
            }
        }
        
        return s.length() - indexStart; //全部走完都沒爆 長度是length-起始的index
        
    }
    
}
