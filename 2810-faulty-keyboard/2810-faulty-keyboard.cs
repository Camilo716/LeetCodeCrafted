public class Solution {
    public string FinalString(string s) {   
        string result = "";

        foreach(char c in s)
        {
            if(c == 'i')
            {
                result = result.Reverse();
                continue;
            }

            result += c;
        }

        return result;
    }
}

public static class StringExtensions 
{
    public static string Reverse(this string s)
    {
        StringBuilder reversed = new();
        int maxIndex = s.Length - 1;

        for(int i = maxIndex; i >= 0; i--)
        {
            reversed.Append(s[i]);
        }

        return reversed.ToString();
    }
}