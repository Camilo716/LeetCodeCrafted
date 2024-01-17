public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string shortestWord = strs.OrderBy(str => str.Length).First();

        for(int i = 0; i < shortestWord.Length; i++)
        {
            var charactersAtPosition = strs.Select(s => s[i]);
            var distinctCharacters = charactersAtPosition.Distinct();
            bool isDifferentCharacter = distinctCharacters.Count() > 1;

            if(isDifferentCharacter)
                return shortestWord[..i];
        }

        return shortestWord;
    }
}