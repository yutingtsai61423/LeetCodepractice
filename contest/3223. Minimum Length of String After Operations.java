class Solution {
    public int minimumLength(String s) {
        char[] arr = s.toCharArray();
        //做字元統計表
        Map<Character, Integer> map = new HashMap<>();
        for (char ch : arr){
            Integer old = map.get(ch);
            int newValue = old == null ? 1 : old + 1;
            map.put(ch, newValue);
        }
        int length = 0;
        for (Map.Entry<Character, Integer> entry : map.entrySet()) {
            Integer old = entry.getValue();
            while (old >= 3){
                old -= 2;
            }
            length += old;
        }

        return length;
        
        
    }
}
