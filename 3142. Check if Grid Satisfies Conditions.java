class Solution {
    public boolean satisfiesConditions(int[][] grid) {
        
        if(checkDown(grid)&&checkRight(grid)){
            return true;
        }
        
        return false;
        
    }
    
    public boolean checkDown(int[][] grid){
        boolean flag = true;
        
        for (int i = 0; i + 1 < grid.length; i++) {
            for (int j = 0; j < grid[i].length; j++) {
                 if(! (grid[i][j] == grid[i + 1][j])) {
                     flag = false;
                     break;
                 }
            }
            
        }
        System.out.println("checkDown= " + flag);
        return flag;
    }
            
            
    public boolean checkRight(int[][] grid){
        boolean flag = true;
        
        for (int i = 0; i < grid.length; i++) {
            for (int j = 0; j + 1 < grid[i].length; j++) {
                 if(!(grid[i][j] != grid[i][j + 1])) {
                     flag = false;
                     break;
                 }
            }
        
        }
        
        System.out.println("checkRight= " + flag);
        return flag;
    }    
}
    
    
    
    
