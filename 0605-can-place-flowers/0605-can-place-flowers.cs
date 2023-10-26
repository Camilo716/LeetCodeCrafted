public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int flowersPlanted = 0;

        for(int i = 0; i < flowerbed.Length; i++)
        {    
            if(flowerbed[i] != 0)
                continue;

            bool leftIsEmpty = i == 0 || flowerbed[i-1] == 0;
            bool rightIsEmpty = i == flowerbed.Length - 1 || flowerbed[i+1] == 0; 
            if(leftIsEmpty && rightIsEmpty)
            {
                flowerbed[i] = 1;
                flowersPlanted++;
            }
        }

        return n <= flowersPlanted;
    }
}