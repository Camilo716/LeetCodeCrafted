public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(' '); 
        var reversered = new List<string>();
    
        for(int i = words.Length - 1; i >= 0; i--)
        {
            if(!string.IsNullOrWhiteSpace(words[i]))
                reversered.Add(words[i]);
        }

        return string.Join(" ", reversered).Trim();
    }
}