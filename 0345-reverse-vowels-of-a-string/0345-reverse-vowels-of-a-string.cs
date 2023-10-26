public class Solution {
    public string ReverseVowels(string s) { 
        char[] withReversedVowels = s.ToCharArray();   

        for(int i = 0, j = withReversedVowels.Length - 1; i < j;)
        {
            if(!isVowel(withReversedVowels[i]))
            {
                i++;
                continue;
            }
            if(!isVowel(withReversedVowels[j]))
            {
                j--;
                continue;
            }
            
            char temp = withReversedVowels[i];
            withReversedVowels[i] = withReversedVowels[j];
            withReversedVowels[j] = temp;

            i++;
            j--;
        }

        return new string(withReversedVowels);
    }

    private bool isVowel(char c)
    {
        var vowels = new char[]{'a', 'e', 'i', 'o', 'u'};
        return vowels.Contains(char.ToLower(c)); 
    }
}