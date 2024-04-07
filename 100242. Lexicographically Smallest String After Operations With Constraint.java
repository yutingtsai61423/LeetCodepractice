class Solution {
    public String getSmallestString(String s, int k) {
     //利用k個步伐，把字母變成a，有多的步伐，把第二個字元變成a
        StringBuilder t = new StringBuilder();
        
        for (int i = 0; i < s.length() && k > 0; i++) {
            char word = s.charAt(i);
            int disToA = Math.min ( word - 'a', 'a'+ 26 - word ); //計算從word走到a的距離 走前走後取比較短的
            
            if (k >= disToA) {
                t.append("a");
                k -= disToA;
            } else { //k不夠用，只能再走最後一步
                t.append(String.valueOf((char)(word-k))); //走不到a了，所以把字降得越小越好
                k = 0; //k用完了
            }
        }
        //把沒用到的字接回來
        t.append(s.substring(t.length()));
        
        return t.toString();
    }
    
}
