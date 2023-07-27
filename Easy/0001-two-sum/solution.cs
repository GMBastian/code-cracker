public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] TwoSumPlacement = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            for(int x = i+1; x < nums.Length; x++)
            {
                if(target == nums[i]+nums[x])
                {
                    Console.WriteLine("i = "+ i + "\nx = " + x);
                    TwoSumPlacement[0] = i;
                    TwoSumPlacement[1] = x; 
                    return TwoSumPlacement;
                }
            }
        }
        return TwoSumPlacement;
    }
}
