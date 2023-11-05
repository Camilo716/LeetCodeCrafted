public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        int sIndex = 0;
        string acronym = string.Concat(words.Select(word => word[0]));
        return acronym == s;         
    }
}