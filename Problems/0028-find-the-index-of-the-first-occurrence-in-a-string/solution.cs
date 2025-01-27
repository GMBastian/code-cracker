public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle == haystack) return 0;

        for(int i = 0; i < haystack.Length; i++)
        {
            if(i + needle.Length <= haystack.Length)
                if(haystack.Substring(i, needle.Length) == needle)
                return i;
        }
        return -1;
    }
}
