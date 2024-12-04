public class Solution {
    public int[] ToArray(Node head) {
        var res = new List<int>();
        var dummy = head;
        while(dummy != null)
        {
            res.Add(dummy.val);
            dummy = dummy.next;
        }
        return res.ToArray();
    }
}
