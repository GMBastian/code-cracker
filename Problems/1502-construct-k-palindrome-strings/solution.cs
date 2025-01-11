public class Solution {
    public bool CanConstruct(string s, int k) {
        var freqMap = new Dictionary<char, int>();
        int singleCount = 0;

        foreach (char c in s) {
            if (freqMap.ContainsKey(c)) {
                freqMap[c]++;
            } else {
                freqMap[c] = 1;
            }
        }

        foreach (var freq in freqMap.Values) {
            if (freq % 2 == 1) {
                singleCount++;
            }
        }

        return singleCount <= k && k <= s.Length;
    }
}
