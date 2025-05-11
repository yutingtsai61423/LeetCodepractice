public class Solution {
        public int MinDeletion(string s, int k)
        {
            int res = 0;
            Dictionary<char, int> sCharAmount = new Dictionary<char, int>();
            //parsing s to amount dictionary
            foreach (char c in s)
            {
                sCharAmount.TryGetValue(c, out int amount);
                sCharAmount[c] = ++amount;
            }

            List<char>[] amountMapToChar =  Enumerable.Range(0, s.Length+1)
                .Select(_ => new List<char>())
                .ToArray();
            
            if(sCharAmount.Count > k)
            {
                foreach ( (char chr, int amount) in sCharAmount)
                {
                    amountMapToChar[amount].Add(chr);
                }

                char[] sortByAmountChar = amountMapToChar.SelectMany(list => list.Select(e => e)).ToArray();

                //刪元素
                int count = sCharAmount.Count;
                int pointer = 0;
                while(count > k)
                {
                    char charToRemove = sortByAmountChar[pointer];
                    res += sCharAmount[charToRemove];
                    sCharAmount.Remove(charToRemove);

                    pointer++;
                    count = sCharAmount.Count;
                }
            }

            return res;
        }
}
