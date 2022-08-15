class Solution {
    public int nearestValidPoint(int x, int y, int[][] points) {
    	//判斷 只要有一個符合 noFit改成false
    	boolean noFit = true;
    	for (int[] arr : points) {
			if (x == arr[0] || y == arr[1]) {
			noFit = false;
			
			}
    	}
    	if(noFit) {
    		return -1;
    	}
    	    	
    	//符合清單存入List
    	List<Integer> list =new ArrayList<>();
    	for (int[] arr : points) {
    		if (x == arr[0] || y == arr[1]) {
    			list.add(arr[0]);
    			list.add(arr[1]);
    			}
		}
    	
    	//找出最小
    	int min = Math.abs(x - list.get(0)) + Math.abs(y - list.get(1));
    	for (int i = 0; i < list.size(); i += 2) {
    		if (Math.abs(x - list.get(i)) + Math.abs(y - list.get(i+1)) < min) {
    			min = Math.abs(x - list.get(i)) + Math.abs(y - list.get(i+1));
    		}
    	}
    	
    	
    	System.out.println(list + "min:" + min);
    	//找出誰符合最小
    	for(int i = 0; i < list.size()-1; i += 2) {
    		if( (Math.abs(x-list.get(i)) + Math.abs(y-list.get(i+1))) > min ) {
    			System.out.println(Math.abs(x-list.get(i)) + Math.abs(y-list.get(i+1)));
    			list.remove(i);
    			list.remove(i);
    			i -= 2;
    		}
    	}
    	System.out.println(list);
    	//找index
    	int counter = 0;
    	
    	outer:
    	for (int[] arr : points) {
    		for (int i = 0; i < list.size()-1; i += 2 ) {
    			if(arr[0] == list.get(i) && arr[1] == list.get(i+1)) {
    				break outer;
    			}	
    		}
    		counter++;
    	}
    	
    	return counter;
	
    }
}
