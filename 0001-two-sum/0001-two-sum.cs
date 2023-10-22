public class Solution {
   public int[] TwoSum(int[] nums, int target) {
        
        var result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                var currNum = nums[i];
                var nextNum = nums[j];

                bool expectedResult = currNum + nextNum == target;

                if (expectedResult)
                {
                    result.Add(i);
                    result.Add(j);
                    return result.ToArray();
                }
            }
        }

        return result.ToArray();
    }
}