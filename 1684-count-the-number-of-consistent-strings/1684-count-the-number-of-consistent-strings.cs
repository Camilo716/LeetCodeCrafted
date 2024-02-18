public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        return words
            .Count(word => AllLettersAreAllowed(word, allowed));
    }

    private bool AllLettersAreAllowed(string word, string allowed)
    {
        return word.All(letter => allowed.Contains(letter));
    }
}