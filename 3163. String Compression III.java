class Solution {
    public String compressedString(String word) {
        int count = 1;
        StringBuilder comp = new StringBuilder();
        char[] wordArr = word.toCharArray();
        for (int i = 0; i < wordArr.length; i++) {
            if ( i+1 < wordArr.length && wordArr[i] == wordArr[i+1] && count <9) {
                count++;
            } else if ( count == 9 ||  i+1 >= wordArr.length || wordArr[i] != wordArr[i+1] ) {
                comp.append(count + "" + wordArr[i]);
                // System.out.println("目前COMP="+ comp.toString());
                count = 1;
            }
        }
        return comp.toString();
        
    }
}
