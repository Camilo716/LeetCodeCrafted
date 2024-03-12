public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int goodPairs = 0;
        int n = nums.Length;

        for(int i = 0; i < n; i++)
        {
            for(int j = i + 1; j < n; j++)
            {
                if(nums[i] == nums[j])
                    goodPairs++;
            }
        }

        return goodPairs;
    }
}