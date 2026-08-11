public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // if (nums.Length == 2 && nums[0] + nums[1] == target) {
        //     return new int[] {0, 1};
        // }

        Dictionary<int, int> results = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            
            if(results.ContainsKey(diff)) {
                return new int[] {results[diff], i};
            }

           results.Add(nums[i], i); 
            // if(!results.TryAdd(diff, i)){
            //     results.Add(diff, i);
            // } else {
            //     return new int[] {results[diff], i};
            // }
        }

        // foreach(var kv in results) {
        //     var key = target - kv.Key;
        //     if(results.ContainsKey(key)) {
        //         return new int[] {kv.Value, results[key]};
        //     }
        // }

        // for(int i = 0; i < nums.Length; i++) {
        //     var key =  target - nums[i];
        //     if (results.ContainsKey(key)) {
        //         return new int[] {i,results[key]};    
        //     }
        // }

        return new int[] {0,0};     
    }
}
