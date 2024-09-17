class Solution {
    public int numberOfSpecialChars(String word) {
        int[] arr = word.chars().toArray(); //string.chars()把字串變成字元intStream
    
        int[] indextAtwordArr = new int[123]; //index=abc字元   值=在arr的index
        Arrays.fill(indextAtwordArr, -1); //給初始值
        
        //最後一個c 要在第一個C之前 所以小寫字母要選最大index存 大寫字母要選最小index存  A=65 a=97
        for (int i = 0; i < arr.length; i++){
        	    int charWord = arr[i];

        	if(charWord >= 97 && i > indextAtwordArr[charWord]) { //若小寫 且在arr的index > 已經存入indextAtwordArr的index 就更新 
        		indextAtwordArr[charWord] = i;
        	}
        	
          	if(charWord < 97) { //若大寫 且在arr的index < 已經存入indextAtwordArr的index 就更新 
        		//
                if(indextAtwordArr[charWord] == -1){
                   indextAtwordArr[charWord] = i;
                } 
                
                if(i < indextAtwordArr[charWord]){
                    indextAtwordArr[charWord] = i;
                }
        	}
        }
        
        int count = 0;
        for(int i = 0; i < 26 ; i++) {
        	boolean lowercount = indextAtwordArr[i + 65] >= 0;
        	boolean uppercount = indextAtwordArr[i + 97] >= 0 ;
        	boolean lowerSmallerThanUpper =  indextAtwordArr[i + 97] < indextAtwordArr[i + 65];
        	
        	if(lowercount
        			&& uppercount
        			&& lowerSmallerThanUpper ) { //如果兩個大小寫都在~~~且比較index大小 
        		count++;
        	}
        }
        
        return count;
    }
}
