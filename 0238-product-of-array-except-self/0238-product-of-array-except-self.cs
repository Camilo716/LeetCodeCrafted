public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        
        int productToRight = 1;
        for(int i = 0; i < nums.Length - 1; i++)
        {
            productToRight *= nums[i];
            answer[i+1] = productToRight;
        }

        answer[0] = 1;
        int productToLeft = 1;
        for(int i = nums.Length - 1; i > 0; i--)
        {
            productToLeft *= nums[i];
            answer[i-1] *= productToLeft;
        }
        
        return answer;
    }
}