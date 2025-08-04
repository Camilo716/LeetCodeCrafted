public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var uniques = new List<int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(uniques.Contains(nums[i]))
            {
                nums[i] = int.MaxValue;
                continue;
            }

            uniques.Add(nums[i]);
        }

        Array.Sort(nums);

        return nums.ToList().Count(x => x != int.MaxValue);
    }
}