public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] freq = new int[26];

        foreach(var q in s) {
            var index = q - 'a';
            freq[index]++;
        }

        foreach(var q in t) {
            var index = q - 'a';
            freq[index]--;
        }

        foreach(var q in freq) {
            if (q != 0) {
                return false;
            }
        }

        return true;
    }
}
