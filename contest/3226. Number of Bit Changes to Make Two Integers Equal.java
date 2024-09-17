class Solution {
    public int minChanges(int n, int k) {
        System.out.println("---------");
        String binaryN = getBinary(n);
        String binaryK = getBinary(k);
        
        if (binaryN.length() < binaryK.length()) return -1;
        if (binaryN.length() != binaryK.length()){
            int diff = binaryN.length()- binaryK.length();
            while(diff > 0){
                binaryK = "0"+binaryK;
                diff--;
            }                
        }
        
        int count = 0;
        for(int i = 0; i < binaryK.length(); i++){
            if(binaryN.charAt(i) < binaryK.charAt(i)){
                return -1;
            } else if(binaryN.charAt(i) != binaryK.charAt(i)){
                count++;
            }
        }
        
        return count;
        
    }
    
    public String getBinary(int num){
        StringBuilder str = new StringBuilder();
        while(num > 0){
            str.insert(0, num % 2);
            num = num / 2 ;
        }
        System.out.println(str.toString());
        return str.toString();
        
    }
}
