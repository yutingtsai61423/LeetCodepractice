class Solution {
    public int numberOfSpecialChars(String word) {
        //整理字串 
        int[] arr = word.chars().distinct().sorted().toArray(); //string.chars()把字串變成字元intStream
        
        boolean[] alpha = new boolean[123]; //A=65 a=97 
        Arrays.stream(arr).forEach(e -> alpha[e] = true);
        
        int count = 0;
        for(int i = 0; i < 26 ; i++) {
        	if(alpha[i + 65] && alpha[i + 97]) {
        		count++;
        	}
        }
        
        return count;
    }
}
