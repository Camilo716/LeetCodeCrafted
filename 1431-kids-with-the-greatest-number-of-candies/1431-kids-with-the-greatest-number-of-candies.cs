public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var result = new bool[candies.Length];
        
        for(int i = 0; i < candies.Length; i++)
        {
            result[i] = IsTheGreatestAmongTheOthers(candies[i] + extraCandies, candies); 
        }

        return result;
    }

    private bool IsTheGreatestAmongTheOthers(int value, int[] others)
    {
        bool isGreatest = true;

        foreach(int other in others)
        {
            if(other > value)
            {
                isGreatest = false;
            }
        }
        return isGreatest;
    }
}