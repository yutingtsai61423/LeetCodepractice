import java.util.regex.Pattern;
import java.util.regex.Matcher;
class Solution {
    public boolean isValid(String word) {
        Pattern pattern1 =  Pattern.compile("^[0-9A-Za-z]{3,}$");
        Pattern pattern2 =  Pattern.compile("^\\w*[aeiouAEIOU]{1,}\\w*$");
        Pattern pattern3 =  Pattern.compile("^\\w*[qzwsxdcrfvtgbyhnjmklpQZWSXDCRFVTGBYHNJMKLP]{1,}\\w*$");
        System.out.println( pattern1.matcher(word).matches() );
        System.out.println( pattern2.matcher(word).matches() );
        System.out.println( pattern3.matcher(word).matches() );
        
        if (   pattern1.matcher(word).matches() 
            && pattern2.matcher(word).matches() 
            && pattern3.matcher(word).matches()) {
            return true;
        }
        return false;
        
    }
}
