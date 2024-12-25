public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numIndices = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if(numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i };
            }

            numIndices[nums[i]] = i;
        }

        throw new InvalidOperationException();
    }
}