public class Solution {
    public int[] SortedSquares(int[] nums) {
        for(int x = 0; x < nums.Length; x++)
        {
            nums[x] = nums[x] * nums[x];
        }
         Array.Sort(nums);
        return nums;
    }
}
