public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequency = new Dictionary<int, int>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (!frequency.TryAdd(nums[i], 1))
            {
                frequency[nums[i]]++;
            }
        }
        
        List<int>?[] buckets = new List<int>[nums.Length + 1];
        
        foreach(var (num, bucketIndex) in frequency)
        {
            var bucketItems = buckets[bucketIndex];
            if (bucketItems == null)
            {
                bucketItems = [];
                buckets[bucketIndex] = bucketItems;
            }
            bucketItems.Add(num);
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
