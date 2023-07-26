public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        List<int> ConsecutiveOnes = new List<int>();
        int Ones = 0;
        for(int x = 0; x < nums.Length ; x++)
        {
            if(nums[x] == 1)
            {
                Ones ++;
            }else{
                ConsecutiveOnes.Add(Ones);
                Ones = 0;
            }
        }
        ConsecutiveOnes.Add(Ones);
            return ConsecutiveOnes.Max();
    }
}
