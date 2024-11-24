class Solution {
    public boolean isPalindrome(int x) {
            if(x < 0)
	 			return false;
	 		
	 		String str = String.valueOf(x);
	 		String str1 = null;
	 		String str2 = null;
	 		str1 = str.substring(0, str.length() / 2);
	 		System.out.println("str1 = " + str1);
	 		if(str.length() % 2 == 0) {
	 			str2 = str.substring(str.length() / 2);
	 			System.out.println("str2 = "+ str2);
	 		} else {
	 			str2 = str.substring(str.length() / 2 + 1);
	 			System.out.println("str2 = "+ str2);
	 		}
	 		
	 		for (int i = 0; i < str1.length(); i++) {
	 			  if(str1.charAt(i) != str2.charAt(str2.length()-1 - i)) {
	 				  return false;
	 			  }
	 		}
	 		
	 		return true;
    }
}
