public class Solution {
    readonly char[] _alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    Dictionary<char, char> decodingMap = new();

    public string DecodeMessage(string key, string message) {
        BuildDecodingMap(key);
        StringBuilder decoded = new();

        foreach(char c in message)
        {
            decoded.Append(decodingMap[c]);
        }

        return decoded.ToString();
    }

    private void BuildDecodingMap(string key)
    {
        decodingMap.Add(' ', ' ');
        int alphabetPointer = 0;

        foreach(char c in key)
        {
            if(decodingMap.ContainsKey(c)) continue;

            decodingMap.Add(c, _alphabet[alphabetPointer]);
            alphabetPointer++;
        }
    }
}