public class Solution {
    public string ReverseWords(string s) {
        List<string> words = s.Split(' ').ToList();

        for(int i = 0; i < words.Count(); i++)
        {
            words[i] = Reverse(words[i]);
        }

        return string.Join(' ', words);
    }

    private string Reverse(string sequence)
    {
        StringBuilder reversed = new();
        int maxIndex = sequence.Length - 1;

        for(int i = maxIndex; i >= 0; i--)
        {
            reversed.Append(sequence[i]);
        }

        return reversed.ToString();
    }
}