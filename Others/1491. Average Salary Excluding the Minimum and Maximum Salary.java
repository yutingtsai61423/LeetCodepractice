class Solution {
    public double average(int[] salary) {
        Arrays.sort(salary);
        int sum = 0;
        double avg = 0.0;
        for (int i = 1; i < salary.length-1; i++) {
        	sum += salary[i];
        }
        avg = (double)sum / (salary.length-2);
        return Double.parseDouble(new DecimalFormat("#.00000").format(avg));
    }
}
