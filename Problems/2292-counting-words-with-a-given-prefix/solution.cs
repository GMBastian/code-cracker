public class Solution {
    public int PrefixCount(string[] words, string pref) {
        return words.Count(p=>p.StartsWith(pref));
    }
}
