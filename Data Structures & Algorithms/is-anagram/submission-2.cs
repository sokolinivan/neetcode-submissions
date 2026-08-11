public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> freqS = new();
        Dictionary<char, int> freqT = new();
        
        for (int i = 0; i < s.Length; i++) {
            if (freqS.ContainsKey(s[i])) {
                freqS[s[i]]++;
            }
            else {
                freqS.Add(s[i], 0);
            }
        }

        for (int i = 0; i < t.Length; i++) {
            if (freqT.ContainsKey(t[i])) {
                freqT[t[i]]++;
            }
            else {
                freqT.Add(t[i], 0);
            }
        }

        foreach (var pair in freqS)
        {
            if (!freqT.ContainsKey(pair.Key))
            {
                return false;
            }

            if (pair.Value != freqT[pair.Key])
            {
                return false;
            }
        }

        foreach (var pair in freqT)
        {
            if (!freqS.ContainsKey(pair.Key))
            {
                return false;
            }

            if (pair.Value != freqS[pair.Key])
            {
                return false;
            }
        }

        return true;
    }
}
