class Solution {
    public boolean canMakeArithmeticProgression(int[] arr) {
        Arrays.sort(arr);
        int sub = arr[1]- arr[0];
        boolean flag = true;
        for (int i = 1; i+1 < arr.length; i++) {
            if ((arr[i+1] - arr[i]) != sub) {
                flag = false;
                break;
            }
        }
        return flag;
    }
}
