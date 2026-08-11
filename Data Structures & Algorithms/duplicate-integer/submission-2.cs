public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> map = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++) {
            if(!map.Add(nums[i])) {
                return true;
            }
        }
        return false;
    }
}