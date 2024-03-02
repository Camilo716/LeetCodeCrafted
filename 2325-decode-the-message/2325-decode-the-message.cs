public class Solution {
    readonly char[] _alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    Dictionary<char, char> decodingMap = new();

    public string DecodeMessage(string key, string message) {
        BuildDecodingMap(key);
        StringBuilder decoded = new();

        for(int i = 0; i < message.Length; i++)
        {
            if(message[i] == ' ') 
            { 
                decoded.Append(' ');
                continue; 
            }
            decoded.Append(decodingMap[message[i]]);
        }

        return decoded.ToString();
    }

    private void BuildDecodingMap(string key)
    {
        int alphabetPointer = 0;

        for(int i = 0; i < key.Length; i++)
        {
            if(key[i] == ' ') continue;
            if(decodingMap.ContainsKey(key[i])) continue;

            decodingMap.Add(key[i], _alphabet[alphabetPointer]);
            alphabetPointer++;
        }
    }
}