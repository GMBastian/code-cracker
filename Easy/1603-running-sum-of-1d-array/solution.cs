public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] result = new int[nums.Count()];
        result[0] = nums[0];
        for(int i = 1;i < nums.Count(); i++)
        {
            result[i] = result[i-1] + nums[i];
        }
        return result;
    }
}
