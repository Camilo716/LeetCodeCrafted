public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        return (!(str1 + str2).Equals(str2 + str1))
            ? ""
            : str1.Substring(0, GetGCD(str1.Length, str2.Length));
    }

    private int GetGCD(int a, int b)
    {
        while(b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }
}