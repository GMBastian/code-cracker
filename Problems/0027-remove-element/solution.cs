public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int j = 0; // Pointer for the position to place elements not equal to val
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[j] = nums[i];
                j++;
            }
        }
        
        return j;
    }
}
