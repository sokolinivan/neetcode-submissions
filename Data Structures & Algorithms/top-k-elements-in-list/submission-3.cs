public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (frequency.ContainsKey(nums[i]))
            {
                frequency[nums[i]]++;
            }
            else
            {
                frequency.Add(nums[i], 1);
            }
        }
        
        var queue = new PriorityQueue<int, int>();

        foreach (var kv in frequency)
        {
            queue.Enqueue(kv.Key, kv.Value * -1);
        }

        var result = new int[k];

        for (int i = 0; i < k; i++)
        {
            result[i] = queue.Dequeue();
        }

        return result;
    }
}
