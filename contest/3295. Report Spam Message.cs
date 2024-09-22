public class Solution {

    public bool ReportSpam(string[] message, string[] bannedWords)
    {
        List<string> banList = bannedWords.ToList();
        // SortedSet<string> banSet = new SortedSet<string>(bannedWords);
        banList.Sort();

        List<string> msgList = message.ToList();
        msgList.Sort();

        int banPtr = 0;
        int count = 0;
        for (int msgPtr = 0; msgPtr < msgList.Count; msgPtr++)
        {
            while (banPtr < banList.Count - 1 && msgList[msgPtr].CompareTo(banList[banPtr]) > 0)
            {
                banPtr++;
            }
            if (msgList[msgPtr] == banList[banPtr]) count++;
            // Console.WriteLine($"msgList[msgPtr]= {msgList[msgPtr]} banList[banPtr] = {banList[banPtr]} count = {count}");
            if (count >= 2) return true;
        }
        return false;
    }
}
