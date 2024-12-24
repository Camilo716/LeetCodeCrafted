public class Solution {
    public int LengthOfLastWord(string s) {
        const string space = " ";

        return s
            .Trim()
            .Split(space)
            .Last()
            .Length;
    }
}