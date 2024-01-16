public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        Dictionary<string, int> mapRuleKeyToIndex = new () {
            { "type", 0 },
            { "color", 1 },
            { "name", 2 }
        };

        return items.Count(item => 
        {
            int index = mapRuleKeyToIndex[ruleKey];
            return item[index] == ruleValue;
        });
    }
}