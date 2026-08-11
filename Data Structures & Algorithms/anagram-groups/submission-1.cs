public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs.Length == 1) {
            return new List<List<string>>()
            {
                new List<string>()
                {
                    strs[0]
                }
            };
        }
        
        var frequencies = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            var frequency = GetFrequency(strs[i]);

            if (!frequencies.ContainsKey(frequency))
            {
                frequencies.TryAdd(frequency, new List<string> { strs[i] });
            }
            else
            {
                frequencies[frequency].Add(strs[i]);   
            }
        }

        return frequencies.Values.ToList();
    }
    
    private string GetFrequency(string s)
    {
        int[] frequency = new int[26];
        
        for (int i = 0; i < s.Length; i++) {
            frequency[s[i] - 'a']++;
        }
        
        return string.Join(",", frequency);
    }
}
