class Solution {
    public int maxHeightOfTriangle(int red, int blue) {
        // System.out.println("=========start test=========");
        return Math.max(height(red, blue), height(blue, red));
        
    }

    public int height(int first, int second){//1 1
        int i = 1; 
        while(true){
            if(i % 2 == 1 &&  first > 0){
                first -= i;
                if ( second - (i + 1) < 0) break;
                i++;
            } else  if (i % 2 == 0 && second > 0){
                second -= i;
                if ( first - (i + 1) < 0) break;
                i++;
            }
                        
            
        }
        // System.out.println("height = " + i);
        // System.out.println("-------------");
        return i;
    }
}
