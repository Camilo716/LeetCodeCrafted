public class Solution {
    public int RomanToInt(string s) {
        int convertedToInt = 0;

        var roman_integer = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        for (int i = 0; i < s.Length-1; i++)
        {
            int actualNumber = roman_integer[s[i]];
            int nextNumber = roman_integer[s[i+1]];

            if (actualNumber < nextNumber )
            {
                convertedToInt -= actualNumber;
            }
            else
            {
                convertedToInt += actualNumber;
            }
        }

        return convertedToInt += roman_integer[s[s.Length-1]];
    }
}