public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hashSet = new HashSet<int>(nums.Length);

        foreach(var num in nums) {
            if(!hashSet.Add(num)) {
                return true;
            }
        }

        return false;
    }
}