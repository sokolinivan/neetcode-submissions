public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> hash = new Dictionary<string, List<string>>(strs.Length);

	
        for (int i = 0; i < strs.Length; i++) {
            int[] freq = new int[26];
            
            for (int j = 0; j < strs[i].Length; j++) {
                freq[strs[i][j] - 'a']++;
            }
            
            string key = string.Join(",", freq);
            
            if (!hash.ContainsKey(key)) {
                hash.Add(key, new List<string>() {strs[i]});
            } else {
                hash[key].Add(strs[i]);
            }
        }
        
        return new List<List<string>>(hash.Values);
    }
}
