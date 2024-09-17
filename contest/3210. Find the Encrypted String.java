class Solution {
    public String getEncryptedString(String s, int k) {
        char[] sArr = s.toCharArray();
        StringBuilder result = new StringBuilder();
        int sLen = s.length();
        for (int i = 0; i < sLen; i++) {
            result.append(sArr[(i + k) % sLen]);
            // System.out.print(sArr[(i + k) % sLen]);
        }
        // System.out.print("\n" + result.toString());
        return result.toString();
    }
}
