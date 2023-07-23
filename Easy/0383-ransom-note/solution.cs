public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(ransomNote.Length > magazine.Length) return false;
        for(int i = 0; i < ransomNote.Length; i++)
        {
            var idx = magazine.IndexOf(ransomNote[i]);
            if(idx == -1){
                return false;
                }
                magazine = magazine.Remove(idx,1);
                }
                return true;
                }
}
