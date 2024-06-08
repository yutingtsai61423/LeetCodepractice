class Solution {
    public String clearDigits(String s) {
        StringBuilder result = new StringBuilder();
        
        for (int i = 0; i < s.length(); i++) {
            char chr = s.charAt(i);
            //0~9的ASCIICODE不是0~9
            int value = chr - '0';
            System.out.println(value);
            if(value <= 9 && result.length() > 0) { //如果是數字
                result.deleteCharAt(result.length() - 1);
            } else {
                result.append(chr);
            }
        }

        return result.toString();
    }
}
