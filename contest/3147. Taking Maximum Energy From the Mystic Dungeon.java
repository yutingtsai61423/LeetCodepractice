class Solution {
    public int maximumEnergy(int[] energy, int k) {
        //依照 % k 後餘數會是0 ~ k-1，K種數字組合，分別計算總和
        int[] sumByRemainderIndex = new int[k];
        
        for (int i = 0; i < energy.length; i++) {
            int kk = i % k;
            sumByRemainderIndex[kk] += energy[i];
        }
        
        // System.out.print("index % k 一樣的和= ");
        // for (int sum : sumByRemainderIndex) {
        //     System.out.print(sum +" ");
        // }
        // System.out.println("");
        
        //找每個 %k 的最大
        int[] sumFromHead = new int[k];//從頭加
        int[] maxOfsumByRemainder = Arrays.copyOf(sumByRemainderIndex, sumByRemainderIndex.length); //存扣完後的最大值
        for (int i = 0; i < energy.length - k ; i++) { //倒數三個要保留
            int kk = i % k;
            sumFromHead[kk] += energy[i];
            //如果撥過去會變大
            int before = sumByRemainderIndex[kk];
            int after = sumByRemainderIndex[kk] - sumFromHead[kk];
            // System.out.println("i=" +i );
            // System.out.println("原本 = "+ before +"  減完sumFromHead["+ kk +"] "+sumFromHead[kk]+"後 = " + after );
            if(after > maxOfsumByRemainder[kk]){
                maxOfsumByRemainder[kk]= after;
                // System.out.println("減完變大 最大值為 " + after);
            } else {
                // System.out.println("減完沒變大");
            }
        }
            
       //找最大值     
        return Arrays.stream(maxOfsumByRemainder).max().getAsInt();
        
    }
}
