public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequency = new Dictionary<int, int>();
        
        foreach (int n in nums)
        {
            if (frequency.ContainsKey(n))
            {
                frequency[n]++;
            }
            else
            {
                frequency[n] = 1;
            }
        }
        
        var buckets = new List<int>[nums.Length + 1];
        
        foreach (var (n, c) in frequency)
        {
            (buckets[c] ??= []).Add(n);
        }

        
        var itemsFound = 0;
        int[] result = new int[k];
        
        
        for(int i = buckets.Length; i > 0; i--)
        {
            var bucketItems = buckets[i];
            
            if (bucketItems == null)
                continue;
            
            foreach(var num in bucketItems)
            {
                result[itemsFound] = num;
                itemsFound++;
                if (itemsFound == k)
                    return result;
            }
        }

        return result;
    }
}
