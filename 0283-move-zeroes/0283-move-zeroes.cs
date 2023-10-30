public class Solution {
    public void MoveZeroes(int[] nums) {        
        int withoutZeroCounter = 0;
        foreach(int num in nums)
        {
            if(num != 0)
            {
                nums[withoutZeroCounter] = num;
                withoutZeroCounter++;
            }
        }

        for(int i = withoutZeroCounter; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}