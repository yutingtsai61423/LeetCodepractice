class Solution {
    public int maxBottlesDrunk(int numBottles, int numExchange) {
        int emptyBottles = 0;
        int bottlesDrunk = 0;
        int fullBottles = numBottles;
        
        //先喝
        while(fullBottles > 0){
            emptyBottles += fullBottles;
            bottlesDrunk += fullBottles;
            fullBottles = 0;
            
            //是否可以空瓶換水? //一次只能換一個 numExchange 的量
            if(emptyBottles >= numExchange){
                System.out.printf("[empty bottles= %d,numExchange = %d, do exchange]\n",emptyBottles, numExchange );
                emptyBottles -= numExchange;
                fullBottles += 1;
                numExchange++;
                System.out.printf("[empty bottles= %d,numExchange = %d, fullBottles=%d],finish exchange\n",emptyBottles, numExchange, fullBottles );
            }
            
        }
        
        return bottlesDrunk;
        
        
    }
}
