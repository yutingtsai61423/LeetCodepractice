class Solution {
    public int[] occurrencesOfElement(int[] nums, int[] queries, int x) {
        
        
        List<Integer> position = new ArrayList<>();
        // System.out.print("position : ");
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == x ) {
                position.add(i);
                // System.out.print(i + " ");
            }
        }
         // System.out.println("");
        
        int[] answer = new int[queries.length];
        int i = 0;
        
        for (int q : queries) { 
            try {
                answer[i] = position.get(q-1);
            } catch (IndexOutOfBoundsException e) {
                answer[i] = -1;
            }
            // System.out.print(answer[i]+ " ");
            i++;
        }
        
        return answer;
    }
}
