using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public IList<string> WordSubsets(string[] words1, string[] words2) {
        // Combine the frequency requirements of words2 into a single array
        int[] requiredFreq = new int[26];
        foreach (string word in words2) {
            int[] freq = GetCharFrequency(word);
            for (int i = 0; i < 26; i++) {
                requiredFreq[i] = Math.Max(requiredFreq[i], freq[i]);
            }
        }

        // Check each word in words1 against the combined frequency requirements
        List<string> result = new List<string>();
        foreach (string word in words1) {
            int[] wordFreq = GetCharFrequency(word);
            if (IsUniversal(wordFreq, requiredFreq)) {
                result.Add(word);
            }
        }

        return result;
    }

    // Helper method to count character frequencies
    private int[] GetCharFrequency(string word) {
        int[] freq = new int[26];
        foreach (char c in word) {
            freq[c - 'a']++;
        }
        return freq;
    }

    // Helper method to check if a word meets the required frequencies
    private bool IsUniversal(int[] wordFreq, int[] requiredFreq) {
        for (int i = 0; i < 26; i++) {
            if (wordFreq[i] < requiredFreq[i]) {
                return false;
            }
        }
        return true;
    }
}

