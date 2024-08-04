class Solution {
   public int winningPlayerCount(int n, int[][] pick) {
    	//n = 4, pick = [[0,0],[1,0],[1,0],[2,1],[2,1],[2,0]]
    	
    	//加總球數表
        Map<Integer, Map<Integer, Integer>> table = new HashMap<>();  
        
        for (int[] xy : pick) {
        	int player = xy[0];
        	int color = xy[1];
        	
        	Map<Integer, Integer> mapColor = table.get(player);
        	
    		//此玩家沒出現過
        	if (mapColor == null) {
        		Map<Integer, Integer> mapColorNew = new HashMap<Integer, Integer>();
        		mapColorNew.put(color, 1);
        		table.put(player, mapColorNew);
        	} else {
        		//有出現過
        		int curCount =  mapColor.getOrDefault(color, 0);
        		mapColor.put(color, curCount + 1);
        	}
        	
        }
        
        int winner = 0;
        
        for (Map.Entry<Integer, Map<Integer, Integer>> entry: table.entrySet()) {
        	//拿出一個玩家
        	int player = entry.getKey();
        	if (entry.getValue().entrySet().stream().filter(e -> e.getValue() > player).findAny().isPresent()){
        		winner++;
        		continue;
        	}
        }
        
    	return winner;
    }
}
