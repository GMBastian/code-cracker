public class Solution {
    public int FindNumbers(int[] nums) {
        int totEvenNumbers = 0;
        for(int x = 0; x< nums.Length; x++)
        {
            string currVal = nums[x].ToString();
            int currValLength = currVal.Length;
            if(currValLength % 2 == 0)
            {
                totEvenNumbers ++;
            }
        }
        return totEvenNumbers;
    }
}
