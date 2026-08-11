public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequences = new Dictionary<int, int>();
        var counts = new List<List<int>>(nums.Length);

        for(int i = 0; i <= nums.Length; i++) 
        {            
            counts.Add(new List<int>());
        }
        
        foreach(var num in nums) {
            if(!frequences.TryAdd(num, 1)) {
                frequences[num]++;
            }
        }

        foreach(var (num, freq) in frequences)
        {
            counts[freq].Add(num);
        }

        var result = new List<int>(k);

        for(var i = counts.Count() - 1; i > 0; i--)
        {
            foreach(var n in counts[i]) {
                result.Add(n);
                if (result.Count() == k)
                    return result.ToArray();
            }
        } 

        return result.ToArray();
    }
}
