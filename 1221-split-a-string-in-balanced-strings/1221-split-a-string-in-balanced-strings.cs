public class Solution {
    public int BalancedStringSplit(string s) {
        int r = 0;
        int l = 0;
        int maximumNumberOfBalanced = 0;

        foreach(char c in s)
        {
            if(c == 'R')
                r++;
            else
                l++;

            if(r == l)
            {
                maximumNumberOfBalanced++;
                r = 0; 
                l = 0;
            }
        }

        return maximumNumberOfBalanced;
    }
}