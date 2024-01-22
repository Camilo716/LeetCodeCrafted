public class Solution {
    public string KthDistinct(string[] arr, int k) {
        string result = "";

        var wordsThatAppearsOnlyOnce = arr.Where(word => arr.Count(w => w == word) == 1);
        
        bool kNotPresent = k > wordsThatAppearsOnlyOnce.Count();
        if(!kNotPresent)
            result = wordsThatAppearsOnlyOnce.ElementAt(k - 1);

        return result;
    }
}