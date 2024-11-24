class Solution {
    public List<Integer> findAnagrams(String s, String p) {
			
		List<Integer> ans = new ArrayList<Integer>();
		
		if(p.length() > s.length()) {
			return  ans;
		}
		
		//製作p map
		Map<Character, Integer> target = new HashMap<Character, Integer>();
		for (int i = 0; i < p.length(); i++) {
			Character curChar = p.charAt(i);
 			Integer value = target.getOrDefault(curChar, 0);
 			target.put(curChar, value + 1);
		}
		// System.out.println("target " + target);
		
		//製作s map
		Map<Character, Integer> sMap = new HashMap<Character, Integer>();
		for (int i = 0; i < p.length(); i++) {
			Character curChar = s.charAt(i);
			Integer value  =  sMap.getOrDefault(curChar, 0);
			sMap.put(curChar, value + 1);
		}
		// System.out.println("sMap " + sMap);
		

		
		//比對開始
		for (int i = 0; i < s.length() - p.length() + 1; i++) {
			System.out.println("----------------");
			Character curChr = s.charAt(i);
			// System.out.println("開始比對第 " + i +" 個" + curChr);

			if (i > 0) { //非第一回合
				Integer value = sMap.getOrDefault(s.charAt(i + p.length()-1) , 0);
				sMap.put(s.charAt(i + p.length()-1), value + 1);
			}
			
			// System.out.println("target " + target);
			// System.out.println("sMap " + sMap);
			
			//比較map的內容有沒有一樣
			if(target.equals(sMap)) {
				ans.add(i);
				// System.out.println("有包含");
			}
			//移掉當前回合的值
			Integer value = sMap.get(curChr);
			
			if (value -1 == 0) {
				sMap.remove(curChr); 
			} else {
				sMap.put(curChr, value - 1);
			}
		}
		
		
		return ans;
    }
}
