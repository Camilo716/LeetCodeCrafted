public class Solution {
    public int StrStr(string haystack, string needle) {
        string ocurrence = string.Empty;

        for(int i = 0; i < haystack.Length; i++)
        {
            ocurrence += haystack[i];

            if(!ocurrence.Contains(needle))
                continue;

            if(ocurrence.Length == needle.Length)
                return 0;

            Stack<char> result = [];

            for(int j = ocurrence.Length - 1; j >= 0; j--)
            {
                result.Push(ocurrence[j]);

                if(new string(result.ToArray()) == needle)
                    return j;
            }
        }

        return -1;
    }
}