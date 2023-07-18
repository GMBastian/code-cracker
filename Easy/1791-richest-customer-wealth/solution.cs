public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxCustomerWealth = int.MinValue;
        for(int i = 0; i < accounts.Length; i++)
        {
            if(accounts[i].Sum() > maxCustomerWealth)
            {
                maxCustomerWealth = accounts[i].Sum();
            }
        }
        return maxCustomerWealth;
    }
}
