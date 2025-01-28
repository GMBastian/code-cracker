public class Solution {
    public int MySqrt(int x) {
        if (x == 1 || x == 0)
        return x;
        // can use binary search to effectively use identify the mid value to identify the sqrt.
        int left = 1;
        int right = x/2; // the x value can be halved to reduce the itenerations

        while (left <= right)
        {
            //identifying the mid and avoid overflowing
            int mid = left + (right - left)/2;
            int sqrt = x/mid;

            if(sqrt == mid)
            return mid;
            else if(sqrt < mid)
            right = mid -1;
            else
            left = mid +1;
        }
        return right;
    }
}
