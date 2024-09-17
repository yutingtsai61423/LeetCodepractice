class Solution {
    public String getSmallestString(String s) {
        //交換鄰近的同奇數/同偶數1次 已達最小字典序
        char[] arr = s.toCharArray();
        
        for (int i = 0; i < arr.length - 1; i++ ) {
            //1.找隔壁是否同為奇數或同為偶數
            //2.若左>右 交換 return
            int ii = arr[i] % 2 ;
            int iiadd1 = arr[i+1] % 2 ;
            
            if (arr[i] % 2 == arr[i+1] % 2 && arr[i] > arr[i+1]) {
            
                char tmp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = tmp;
            
                
                break;            
            }
        }
        
        String new1 = new String(arr);
                
        return   new1;
        
        
        
    }
}
