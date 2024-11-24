class Solution {
    public int subtractProductAndSum(int n) {
            	String str = Integer.toString(n);
    	ArrayList<Integer> list = new ArrayList<>();
    	for (int i = 0; i < str.length(); i++) {
    		String str1 = str.substring(i,i+1);
    		int temp = Integer.valueOf(str1);
    		list.add(temp);
    	}
    	int product = 1;
    	int sum = 0;
    	for (int a : list) {
    		sum += a;
    		product *= a;
    	}
		return product - sum;
    }
}
