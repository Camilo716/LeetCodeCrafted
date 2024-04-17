public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        return patterns
            .ToList()
            .Count(pattern => word.Contains(pattern));
    }
}