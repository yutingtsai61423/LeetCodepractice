class Solution {
    public int minimumOperationsToMakeKPeriodic(String word, int k) {
        //問題變為找用k長度切字串 substring(i, i+k) 此字串重複次數最高的字串 看看到底重複幾次  組數-重複次數=ans
        Map<String, Integer> mapOfSubStr = new HashMap<>();
        
        for (int i = 0; i + k <= word.length(); i=i+k) {
            String substr = word.substring(i, i + k);
             // System.out.println("processing "+ i + "~" + (i + k) +" = " +substr);
            Integer count = mapOfSubStr.get(substr);
            if(null == count){
                mapOfSubStr.put(substr, 1);
            } else {
                mapOfSubStr.put(substr, count + 1 );
            }
        }
        
        // for(Map.Entry<String, Integer> entry :  mapOfSubStr.entrySet()){
        //     System.out.println(entry.getKey() + " : " + entry.getValue());
        // }
        //找最大的value
        Integer max = mapOfSubStr.values().stream().max(Comparator.naturalOrder()).get();
        // System.out.println("max=" + max);
        // System.out.println("word.length() / k=" + word.length() / k);
        return (word.length() / k) - max;
    }
}
