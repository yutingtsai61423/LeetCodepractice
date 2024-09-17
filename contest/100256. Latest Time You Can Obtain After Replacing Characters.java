class Solution {
    public String findLatestTime(String s) {
        //換成陣列，若遇到[0][1]==? 要換成1 或遇到[3]== ?要換5 遇到[4]==? 要換9
        
        char[] sArr = s.toCharArray();
        
        System.out.println(String.valueOf(sArr));
        
        if(sArr[0] == '?'){
            if(sArr[1] >= '2' && sArr[1] != '?'){
                sArr[0] = '0';
            } else {
                sArr[0] = '1';
            }
        } 
        
        if (sArr[1] == '?'){
            if(sArr[0] == '1'){
                sArr[1] = '1';
            } else {
                sArr[1] = '9';
            }
        } 
        
        if (sArr[3] == '?'){
            sArr[3] = '5';
        } 
        
        if (sArr[4] == '?'){
            sArr[4] = '9';
        }
        
        return String.valueOf(sArr);
        
    }
}
