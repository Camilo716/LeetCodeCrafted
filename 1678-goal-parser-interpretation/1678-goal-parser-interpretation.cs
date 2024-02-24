public class Solution {
    public string Interpret(string command) {
        var goalMap = new Dictionary<string, string>
        {
            { "G", "G"},
            { "()", "o"},
            { "(al)", "al"}
        };
        StringBuilder result = new();

        string toParse = "";
        foreach(char c in command)
        {
            toParse += c;

            if(!goalMap.ContainsKey(toParse))
                continue;

            result.Append(goalMap[toParse]);
            toParse = ""; 
        }

        return result.ToString();
    }
}