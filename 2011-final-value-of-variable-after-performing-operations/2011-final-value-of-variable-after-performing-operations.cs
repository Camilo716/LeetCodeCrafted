public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int additions = operations.Count(op => op.Contains("+"));
        int substractions = operations.Count(op => op.Contains("-"));

        return additions - substractions;
    }
}