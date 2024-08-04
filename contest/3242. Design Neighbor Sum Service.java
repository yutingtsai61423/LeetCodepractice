
class neighborSum {
	
	int[][] grid;
	int xLength;
	int yLength;
	
    public neighborSum(int[][] grid) {
        this.grid = grid;
        this.xLength = grid.length;
        this.yLength = grid[0].length;
    }
    
    public int adjacentSum(int value) {
        //加總上下左右的數字-共4格
    	int[] position = findPosition(value);
    	int x = position[0];
    	int y = position[1];
    	
    	int left = y - 1 >= 0 ?  grid[x][y - 1] : 0;
    	int right = y + 1 < yLength ? grid[x][y + 1] : 0;
    	int up = x - 1 >= 0 ? grid[x-1][y] : 0;
    	int down = x +1 < xLength ? grid[x+1][y] : 0;
    	
    	return left + right + up + down;
    }
    
    public int diagonalSum(int value) {
        //加總上下左右的數字-共4格
    	int[] position = findPosition(value);
    	int x = position[0];
    	int y = position[1];
    	
    	boolean left = y - 1 >= 0;
    	boolean right = y + 1 < yLength;
    	boolean up = x - 1 >= 0 ;
    	boolean down = x +1 < xLength;
    	
    	
    	int rightup = right && up ? grid[x - 1][y + 1] : 0;
    	int leftup = left && up ? grid[x - 1][y - 1] : 0;
    	int rightdown = right && down ? grid[x +1][y + 1] : 0;
    	int leftdown = left && down ? grid[x +1][y - 1] : 0;
    	
    	return rightdown + rightup + leftdown + leftup;
    }
    
    //找到位置
    public int[] findPosition(int value) {
		int finalX = 0;
		int finalY = 0;
		
		for (int x = 0; x < grid.length; x++) {
			for (int y = 0; y < grid[0].length; y++) {
				if (grid[x][y] == value) {
					finalX = x;
					finalY = y;
				}
			}
		}
    	return new int[] {finalX, finalY};
	}
}

/**
 * Your neighborSum object will be instantiated and called as such:
 * neighborSum obj = new neighborSum(grid);
 * int param_1 = obj.adjacentSum(value);
 * int param_2 = obj.diagonalSum(value);
 */
