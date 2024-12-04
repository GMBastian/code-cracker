public class SparseVector {
    int[] vector;
    public SparseVector(int[] nums) {
        this.vector = nums;
    }
    
    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec) {
        int res = 0;
        for (int i = 0; i< this.vector.Length; i++)
        {
            res += vec.vector[i] * this.vector[i];
        }
        return res;
    }
}

// Your SparseVector object will be instantiated and called as such:
// SparseVector v1 = new SparseVector(nums1);
// SparseVector v2 = new SparseVector(nums2);
// int ans = v1.DotProduct(v2);
