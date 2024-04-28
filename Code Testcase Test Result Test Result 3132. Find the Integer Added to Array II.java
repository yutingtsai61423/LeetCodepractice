/*
deleteNums的邏輯應修正為 for控制 nums1的i，nums2的i則記在外圈 
先假設第一個是符合的，若左右差距正確，加隔壁的
若差距不正確 nums1的i跳下一格
*/

class Solution {
    public int minimumAddedInteger(int[] nums1, int[] nums2) {
        Arrays.sort(nums1);
        Arrays.sort(nums2);
        System.out.println("-----------[做排序]-----------------");
        print(nums1);
        print(nums2);
        System.out.println("-----------------------------");      
        
        nums1 = reverse(nums1);
        nums2 = reverse(nums2);
        System.out.println("-----------[做反轉]-----------------");
        print(nums1);
        print(nums2);
        System.out.println("-----------------------------");        
        
        
        //先假設開頭是對的
        //確認能否經過刪除後面的其中2個達到題目要求
        System.out.println("-----------[做第一次]-----------------");
        int[] newNums1 = deleteNums(nums1, nums2);
        
        boolean correct = check(newNums1, nums2) ;
        System.out.println(correct);
        if (!correct){
            //刪除第一個元素
             System.out.println("-----------[刪除第一個再做一次]-----------------");
             int[] nums1RemovedFirst = Arrays.copyOfRange(nums1, 1, nums1.length);
             newNums1 = deleteNums(nums1RemovedFirst, nums2);
             correct = check(newNums1, nums2);
            System.out.println(correct);
             if(!correct){ //刪除第二個元素再一次
                 System.out.println("------------[刪除第二個再做一次]----------------");
                 int[] nums1RemovedSecond = Arrays.copyOfRange(nums1, 2, nums1.length);
                 newNums1 = deleteNums(nums1RemovedSecond, nums2);
                 correct = check(newNums1, nums2);
                 System.out.println(correct);
             }
        }
        
        return nums2[0]-newNums1[0];
        
    }
    
    
    public int[] reverse(int[] intarr){
        int[] newarr = new int[intarr.length];
        int j = 0;
        for(int i = intarr.length-1; i >= 0; i--){
            newarr[j++] = intarr[i];
        }
        return newarr;
        
    }
    
    
    public int[] deleteNums(int[] nums1, int[] nums2){
        int[] newNums1 = new int[nums2.length];
        newNums1[0] = nums1[0];
        int tmp = 0;
        for (int iInNums2 = 0; iInNums2 < nums2.length-1; iInNums2++) {
            int distanceNum2 = nums2[iInNums2+1] - nums2[iInNums2]; //num2中 元素和下一個的差距
            
            for (int iInNums1 = tmp; iInNums1 < nums1.length-1; iInNums1++) {
                int distanceNum1 = nums1[iInNums1+1] - nums1[iInNums1];//num1中 元素和下一個的差距
                if(distanceNum1 == distanceNum2){ //差距有對，加自己
                    newNums1[iInNums2] = nums1[iInNums1];
                    System.out.print("newNums1 =");  
                    print(newNums1);
                    break;
                } else{
                    
                    
                    continue;  //差距不對，跳下一個 
                }
            }
        }
        System.out.print("final newNums1 =");  
        print(newNums1);
        return newNums1;
    }
    
    //驗證值平移後兩array是否相同(每個元素相減後值相同)
    public boolean check(int[] newNums1, int[] nums2){
        
        int dis = nums2[0] - newNums1[0];
        
        for (int i = 0; i < newNums1.length; i++) {
            newNums1[i] += dis;
        }
        System.out.println("[do check]");   
        System.out.print("nums2    =");            
        print(nums2);
        System.out.print("位移後的newNums1 =");  
        print(newNums1);
        
        return Arrays.equals(newNums1, nums2);
        
    }
    
    
    public void print(int[] nums){
        for (int i : nums) {
            System.out.print( i+" ");
        }
         System.out.println("");
    }
    
    
}
