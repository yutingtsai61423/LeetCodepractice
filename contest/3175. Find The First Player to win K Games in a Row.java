class Solution {
    public int findWinningPlayer(int[] skills, int k) {
        List<Integer> list = new LinkedList<>();
        for (int i : skills){
            list.add(i);
        }    
        k = Math.min(k, skills.length-1);
        int count = 0;
        while (count < k){
            Integer first = list.getFirst();
            Integer second = list.get(1);
            if (first > second){
                list.remove(second);
                list.addLast(second);
                count++;
            } else {
                list.remove(first);
                list.addLast(first);
                count = 1;
            }
            // System.out.println(list);
        }
        
        //找index
        int index = 0;
        for (int i = 0; i < skills.length; i++){
            if(skills[i] == list.getFirst()){
                index = i;
                break;
            }
        }
        // System.out.println(index);
        return index;
        
    }
}
