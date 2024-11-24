class Solution {
    public int lengthOfLongestSubstring(String s) {
	   int head = 0;
	   int max = 0;
	   
	   
       for (int end = 0; end < s.length(); end++ ) {
        	//找到head開頭end不重複可以走多遠 找到之後，換另一個head開頭
    	   String cur = s.substring(head, end);
		   System.out.println("回合開始 \ncur= "+cur);
    	   if(cur.contains(String.valueOf(s.charAt(end)))) {
    		   System.out.println("有包含 head往前");
    		   while(s.substring(head, end).contains(String.valueOf(s.charAt(end)))) {
    			   head++;
    		   }
    		   
    	   } else { //把自己算進去 如果有比最大值大，更新
    		   max = max < cur.length() + 1 ? cur.length() + 1 : max;
    		   System.out.println("max = " + max);
    	   }
       }
        	
       return max;
    
    }
}
