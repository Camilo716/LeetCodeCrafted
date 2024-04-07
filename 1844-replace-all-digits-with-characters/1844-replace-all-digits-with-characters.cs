public class Solution {
    public string ReplaceDigits(string s) {
        char[] result = s.ToCharArray();
        
        for(int i = 0; i < result.Length; i++)
        {
            if(!char.IsNumber(result[i]))
                continue;
            
            char prevChar = result[i - 1];
            int digit = int.Parse(result[i].ToString());

            result[i] = Shift(prevChar, digit);
        }

        return string.Join("", result);
    }

    private char Shift(char c, int digit)
    {
        return (char)(c + digit);
    }
}