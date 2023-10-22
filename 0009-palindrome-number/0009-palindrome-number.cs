public class Solution {
    public bool IsPalindrome(int x) {
        string literalNum = x.ToString();

        string reversedLiteral = "";

        for (int i = literalNum.Length-1; i >= 0; i--)
        {
            reversedLiteral += literalNum[i];
        }

        return literalNum == reversedLiteral;
    }
}