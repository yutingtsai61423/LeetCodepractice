class Solution {
    public boolean canMakeSquare(char[][] grid) {
        //要滿足有三格，必定要先滿足有兩個
        //先找到兩格一樣的
        for (int i = 0; i < grid.length; i++) {
            
            //只看一維
            if (grid[i][0] == (grid[i][1])) { //前兩個一樣
                if (  ((i + 1) < grid.length && grid[i+1][0] == (grid[i][0]))     //X往下找
                    ||((i + 1) < grid.length && grid[i+1][1] == (grid[i][1]))    //y往下找 
                    ||((i - 1) >= 0          && grid[i-1][0] == (grid[i][0]))    //X往上找
                    ||((i - 1) >= 0          && grid[i-1][1] == (grid[i][1]))){  //y往上找
                        return true;
                    }  
            } 
            
            
            if (grid[i][1] == (grid[i][2])){ //後兩個一樣
                if (  ((i + 1) < grid.length && grid[i+1][1] == (grid[i][1]))     //X往下找
                    ||((i + 1) < grid.length && grid[i+1][2] == (grid[i][2]))     //y往下找 
                    ||((i - 1) >= 0          && grid[i-1][1] == (grid[i][1]))     //X往上找
                    ||((i - 1) >= 0          && grid[i-1][2] == (grid[i][2])) ){  //y往上找
                        return true;
                    }                      
            
            } else {
                continue; //都不一樣
            }
        }
    
           return false;             
    


    }
}
