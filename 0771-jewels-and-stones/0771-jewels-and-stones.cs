public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        return stones
            .ToCharArray()
            .Count(stone => jewels.Contains(stone));
    }
}