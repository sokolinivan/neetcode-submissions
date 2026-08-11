public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> s_map = new Dictionary<char, int>();
        Dictionary<char, int> t_map = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++) {
            if (!s_map.TryAdd(s[i], 1))
            {
                s_map[s[i]]++;
            }
        }

        for (int i = 0; i < t.Length; i++) {
            if (!t_map.TryAdd(t[i], 1))
            {
                t_map[t[i]]++;
            }        
        }

        foreach (var kv in s_map) {
            if (!t_map.ContainsKey(kv.Key)) {
                return false;
            }

            if(s_map[kv.Key] != t_map[kv.Key]) {
                return false;
            }
        }

        return true;
    }
}
