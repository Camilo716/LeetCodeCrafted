public class Solution {
    public string KthDistinct(string[] arr, int k) {
        return arr
            .GroupBy(word => word)
            .Where(group => group.Count() == 1)
            .Select(group => group.Key)
            .ElementAtOrDefault(k-1) ?? "";
    }
}