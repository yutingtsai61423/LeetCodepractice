class Solution {
    public int maxPointsInsideSquare(int[][] points, String s) {
        
        // 獲取 points 陣列的長度，即點的個數
        int n = points.length;
        // 創建一個 ArrayList 來存儲點的索引
        ArrayList<Integer> v = new ArrayList<>();

        // 將所有點的索引添加到 ArrayList v 中
        for (int i = 0; i < n; ++i) {
            v.add(i);
        }

        // 使用 Collections.sort 來排序 ArrayList，排序依據為自定義的比較器
        Collections.sort(v, new Comparator<Integer>() {
            @Override
            public int compare(Integer ia, Integer ib) {
                // 獲取比較的兩個點
                int[] a = points[ia];
                int[] b = points[ib];
                // 比較兩點到原點的最大距離，返回比較結果
                return Integer.compare(Math.max(Math.abs(a[0]), Math.abs(a[1])),
                                       Math.max(Math.abs(b[0]), Math.abs(b[1])));
            }
        });

        // 創建一個整數陣列用於記錄每個字符是否已經見過
        int[] seen = new int[26];

        // 遍歷排序後的索引陣列
        for (int i = 0; i < n; ++i) {
            // 獲取當前點的標籤字符
            char ch = s.charAt(v.get(i));
            // 如果該字符已經見過
            if (seen[ch - 'a'] != 0) {
                // 獲取當前點到原點的最大距離
                int edge1 = Math.max(Math.abs(points[v.get(i)][0]), Math.abs(points[v.get(i)][1]));

                // 逆向遍歷已經處理過的點，尋找邊界變化點
                for (int j = i - 1; j >= 0; --j) {
                    // 比較前一個點到原點的最大距離
                    int edge2 = Math.max(Math.abs(points[v.get(j)][0]), Math.abs(points[v.get(j)][1]));
                    // 如果前一個點的邊界與當前點不同，返回 j + 1，即有效點數
                    if (edge2 != edge1) {
                        return j + 1;
                    }
                }

                // 如果所有點都在同一個邊界上，返回 0
                return 0;
            }

            // 標記當前字符已經見過
            seen[ch - 'a'] = 1;
        }

        // 如果沒有重複標籤，返回所有點的數量
        return n;
        /******************************************************************/
        
//         //製作XY軸
//         TreeMap<Integer, Character> mapX = new TreeMap<>();
//         TreeMap<Integer, Character> mapY = new TreeMap<>();
        
//         for (int i = 0; i < points.length; i ++){
//             mapX.put(points[i][0], s.charAt(i));
//             mapY.put(points[i][1], s.charAt(i));
//         }
        
//         System.out.println(mapX);
//         System.out.println(mapY);
        
//         //利用 TreeMap 自然排序 找X或Y的最大值        
//         int maxDistance = Math.max(mapX.lastKey(), mapY.lastKey());
//         Set<Character> sSet = new HashSet<>();
        
//         for (int i = 1; i <= maxDistance; i++) { //i=邊長
//             //預設是true 如果有重複才改false
//             boolean positiveX = mapX.get(i) != null ? sSet.add(mapX.get(i)) : true;
//             boolean negativeX = mapX.get(-1 * i) != null ? sSet.add(mapX.get(-1 * i)) : true;
            
//             boolean positiveY = mapY.get(i) != null ? sSet.add(mapY.get(i)) : true;
//             boolean negativeY = mapY.get(i) != null ? sSet.add(mapY.get(-1 * i)) : true;
//             //須排除兩個字串跟來自同一點
//             if (positiveX && negativeX && positiveY && negativeY) { //沒重複
//                 System.out.println("距離 " + i + "內沒重複的字串");
//             } else { //有重複
//                 System.out.println("距離 " + i + "內有重複的字串");
//                 System.out.println("最大邊長為"+ (i-1));
//                 return i - 1 ;
//             }
            
//         }
        
//         //全都沒重複
//         System.out.println("全沒重複，最大邊長為"+ maxDistance);
//         return maxDistance;
        
    }
}
