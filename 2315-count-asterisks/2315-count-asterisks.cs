public class Solution {
    public int CountAsterisks(string s) {
        bool isBetweenPair = false;
        int asterisks = 0;

        foreach(char c in s)
        {
            if(c == '|')
                SwitchBoolean(ref isBetweenPair);

            if(!isBetweenPair && c == '*')
                asterisks++;
        }

        return asterisks;
    }

    private void SwitchBoolean(ref bool expression) => 
        expression = expression ? false : true; 
}