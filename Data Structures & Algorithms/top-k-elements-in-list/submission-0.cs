public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        return nums.GroupBy(n => n).OrderBy(g => g.Count()).Select(g => g.Key).ToArray()[^k..];
    }
}
