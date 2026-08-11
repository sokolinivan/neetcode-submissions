public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        
        foreach (var str in strs) {
            var frequency = new int[26];

            foreach (var s in str) {
                frequency[s - 'a']++;
            }

            var key = string.Join(',', frequency);

            if (!map.TryAdd(key, new List<string>() {str})) {
                map[key].Add(str);
            }
        }

        return new List<List<string>>(map.Values);
    }
}
