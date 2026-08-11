public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> results = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            
            if(results.ContainsKey(diff)) {
                return new int[] {results[diff], i};
            }

           results.Add(nums[i], i); 
        }

        return new int[] {0,0};     
    }
}
