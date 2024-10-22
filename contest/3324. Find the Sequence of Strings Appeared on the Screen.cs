public class Solution {
    public IList<string> StringSequence(string target)
    {
        List<string> res = new List<string>();
        char[] tmp = new char[target.Length];
        string tmpS;
        for (int i = 0; i < target.Length; i++)
        {
            char cur = 'a';
            tmp[i] = cur;
            tmpS = new string(tmp.Where(c => c != '\0').ToArray());
            res.Add(tmpS);//char array to string

            while (target[i] != cur)
            {
                tmp[i] = ++cur;
                tmpS = new string(tmp.Where(c => c != '\0').ToArray());
                res.Add(new string(tmpS));
            }
        }
        return res;
    }
}
