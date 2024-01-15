public class Solution {
    public int MostWordsFound(string[] sentences) {
        IEnumerable<int> NumWordsPerSentence = sentences.Select(s => s.Split().Length);
        return NumWordsPerSentence.Max();
    }
}