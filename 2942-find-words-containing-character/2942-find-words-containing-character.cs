public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        var indexes = new List<int>();

        for(int i = 0; i < words.Length; i++)
        {
            if(words[i].Contains(x))
            {
                indexes.Add(i);
            }
        }

        return indexes;
    }
}