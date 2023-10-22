public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string wordMerged = "";
        int word2Index=0;
        string word2Remain = "";

        for(int i = 0; i < word1.Count(); i++)
        {
            wordMerged += word1[i];

            bool indexInRange = word2Index < word2.Count();
            if(indexInRange)
            {
                wordMerged += word2[word2Index];
                word2Remain = word2.Substring(word2Index+1);
                word2Index++;
            }
        }

        wordMerged += word2Remain;
        return wordMerged; 
    }
}