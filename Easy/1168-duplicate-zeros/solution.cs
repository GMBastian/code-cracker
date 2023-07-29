public class Solution {
    public void DuplicateZeros(int[] arr) {
        int j=0;
        for(int i = arr.Length-1; i>=0; i--)
        {
            if(arr[i] == 0)
            {
                j=arr.Length-1;
                while((i+1)< j)
                {
                    arr[j] = arr[j-1];
                    arr[j-1] = 0;
                    j--;
                }
            }
        }
    }
}
