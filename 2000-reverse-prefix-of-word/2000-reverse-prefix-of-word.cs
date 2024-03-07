public class Solution {
    public string ReversePrefix(string word, char ch) {
        int segmentSeparatorIndex = word.IndexOf(ch);
        if(segmentSeparatorIndex < 0) return word;

        string prefix = word.Substring(0, segmentSeparatorIndex + 1);
        string remaining = word.Substring(segmentSeparatorIndex + 1);

        return ReverseString(prefix) + remaining;    
    }

    private string ReverseString(string word)
    {
        StringBuilder reversed = new();

        for(int i = word.Length - 1; i >= 0; i--)
        {
            reversed.Append(word[i]);
        }

        return reversed.ToString();
    }
}