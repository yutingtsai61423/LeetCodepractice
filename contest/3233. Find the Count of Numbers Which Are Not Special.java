class Solution {
	public int nonSpecialCount(int l, int r) {
		//先找l~r中的有幾個是質數的平方數 
		//= 找 根號L和根號R之間有幾個質數
		
		int countPrime = 0; //都平方之後再來找質數有幾個
		double leftSqrt = Math.ceil(Math.sqrt(l));
		double rightSqrt = Math.floor(Math.sqrt(r));
		
		for (int i = (int)leftSqrt; i <= rightSqrt; i++) {
			if (findPrime(i) && i != 1) countPrime++; 
		}
		return r - l + 1 - countPrime;
    }
	
	public boolean findPrime(double n) {
		for (int i = 2; i <= Math.sqrt(n); i++) {
			if (n % i == 0) return false;
		}
		return true;
	}
}
