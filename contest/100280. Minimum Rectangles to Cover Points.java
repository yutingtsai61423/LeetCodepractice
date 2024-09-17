class Solution {
    public int minRectanglesToCoverPoints(int[][] points, int w) {
        //取出X的投影
        Set<Integer> projectionX = new TreeSet<>();
        for(int[] xy : points){
            projectionX.add(xy[0]);//X軸座標加入Set
        }
        System.out.println("set = " + projectionX);
        
        List<Integer> projectionXList = projectionX.stream().collect(Collectors.toList());
        if(projectionXList.size() == 1){
            return 1;
        }
        
        int count = 0;
        int rightBorder = 0;
        for(int i = 0; i < projectionXList.size()-1; i++){
            if( i == 0){ //起始條件
                rightBorder = projectionXList.get(0) + w;
                count++;
            }
            
            if (projectionXList.get(i+1) <= rightBorder){ //看是否有包含在w範圍內 有包含就跳下一個
                continue;
            } else {
                rightBorder = projectionXList.get(i+1) + w; //沒包含在w的範圍內 就跳去該點，然後再包一次w的範圍
                count++;
                continue;
            }
            
        }
       
        
        
        return count;
    }
}
