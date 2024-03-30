class Solution {
    public int minimumLevels(int[] possible) {
        //總得分是一樣的
        int allScore = 0;
        int danielScore = 0;
        for(int score : possible){
            if(score == 1){
                allScore+= 1;
            } else {
                allScore += -1;
            }
        }
        
         
        int level = 0;
        for(int score : possible){
            if(level == possible.length-1){
                return -1;
            }
            if(score == 1){
                danielScore+= 1;
            } else {
                danielScore += -1;
            }   
            int bobScore = allScore - danielScore;
            
            if (danielScore > bobScore){
                // System.out.printf("[at level %d, danielScore = %d > bobScore %d \n", level, danielScore, bobScore);
                return level+1;    
            }
            // System.out.printf("[at level %d, danielScore = %d <= bobScore %d \n", level, danielScore, bobScore);
            level++;
        }
        
        return -1;
    }
}
