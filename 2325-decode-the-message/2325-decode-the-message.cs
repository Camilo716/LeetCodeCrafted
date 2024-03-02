public class Solution {
    readonly char[] _alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    Dictionary<char, char> decodingMap = new();

    public string DecodeMessage(string key, string message) {
        BuildDecodingMap(key);
        StringBuilder decoded = new();

        foreach(char c in message)
        {
            if(c == ' ') 
            {
                decoded.Append(' ');
                continue; 
            }
            decoded.Append(decodingMap[c]);
        }

        return decoded.ToString();
    }

    private void BuildDecodingMap(string key)
    {
        int alphabetPointer = 0;

        foreach(char c in key)
        {
            bool keyExists = decodingMap.ContainsKey(c);
            if(keyExists || c == ' ') continue;

            decodingMap.Add(c, _alphabet[alphabetPointer]);
            alphabetPointer++;
        }
    }
}