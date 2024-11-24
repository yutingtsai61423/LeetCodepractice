public class Solution {
    // you need to treat n as an unsigned value
    public int hammingWeight(int n) {
String str = Integer.toBinaryString(n);
		System.out.println(str);
		int counter = 0;
		for (int i = 0; i < str.length(); i++) {
			if (str.charAt(i) == '1') {
				counter++;
			}
		}
		return counter;
    }
}
