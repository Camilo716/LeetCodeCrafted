public class Solution {
    public string SortSentence(string s) {
        string[] words = s.Split(' ');
        string[] sorted = new string[words.Length];

        foreach(string word in words)
        {
            char lastChar = word[word.Length - 1];

            int position = int.Parse(lastChar.ToString());
            string realWord = word.Substring(0, word.Length-1);

            sorted[position-1] = realWord; 
        }

        return string.Join(' ', sorted);
    }
}