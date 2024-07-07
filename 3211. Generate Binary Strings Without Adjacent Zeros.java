class Solution {
public:
    vector<string> validStrings(int n) {
        vector<string> res;
        string chosen;
        
        backtrack(0, n, chosen, res);
        return res;
    }
    
    void backtrack(int start, int n, string& chosen, vector<string>& res) {
        if (start == n) {
            if (valid(chosen)) {
                res.push_back(chosen);
            }
            return;
        }
        
        chosen.push_back('0');
        backtrack(start + 1, n, chosen, res);
        chosen.back() = '1';
        
        backtrack(start + 1, n, chosen, res);
        chosen.pop_back();
    }
    
    bool valid(string& s) {
        int cnt = 0;
        for (int i = 0; i < s.size() - 1; ++i) {
            if (s[i] == '0' && s[i + 1] == '0') {
                return false;
            }
        }
        
        return true;
    }
};
