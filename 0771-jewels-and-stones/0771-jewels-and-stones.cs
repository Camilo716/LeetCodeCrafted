public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int jewelsFound = 0;

        foreach(char stone in stones)
        {
            if(jewels.Contains(stone))
                jewelsFound++;
        }

        return jewelsFound;
    }
}