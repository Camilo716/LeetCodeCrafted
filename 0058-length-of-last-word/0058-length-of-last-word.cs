public class Solution {
    public int LengthOfLastWord(string s) {
        string lastWord = s
            .Split(' ')
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .LastOrDefault();

        return lastWord?.Length ?? 0;
    }
}