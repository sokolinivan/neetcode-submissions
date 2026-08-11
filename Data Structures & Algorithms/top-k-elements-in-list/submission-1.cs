public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        var bucket = Enumerable.Range(0, nums.Length + 1)
                                .Select(_ => new List<int>())
                                .ToArray();

        for (int i = 0; i < nums.Length; i++) {
            if (!freq.TryAdd(nums[i], 1)) {
                freq[nums[i]]++;
            }
        }
        
        foreach (var (num, count) in freq)
        {
            bucket[count].Add(num);
        }
        
        List<int> result = new List<int>(k);

        for (int i = bucket.Length - 1; i > 0; i--)
        {
            for(int j = 0; j < bucket[i].Count; j++) {
                result.Add(bucket[i][j]);
                
                if(result.Count == k) {
                    return result.ToArray();
                }
            }
        }
        
        return result.ToArray();
    }
}
