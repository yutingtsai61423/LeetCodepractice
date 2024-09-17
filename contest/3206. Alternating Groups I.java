class Solution {
    public int numberOfAlternatingGroups(int[] colors) {
        int[] colorAddHead = new int[colors.length +2];
        for (int i = 0; i < colorAddHead.length; i++) {
            if(i >=  colors.length ){
                colorAddHead[i] = colors[i-colors.length];
                continue;
            }
            colorAddHead[i] = colors[i];
        }
        int count = 0;
        for (int i = 0; i +2 < colorAddHead.length; i++) {
            boolean first = (colorAddHead[i] != colorAddHead[i+1] && colorAddHead[i+1] != colorAddHead[i+2]) ;

            if ( first ){
                    count++;
            }
        }

        return count;

    }
}
