public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> buff = new Dictionary<int, int>(nums.Length);

        for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++) {
            var current = nums[currentIndex];
            var diff = target - current;
            if (buff.ContainsKey(diff)){
                return new int[] {buff[diff], currentIndex};
            } else {
                buff[current] = currentIndex;
            }
        }

        foreach(var kvp in buff) {
            Console.WriteLine($"k: {kvp.Key}; v: {kvp.Value}");
        }

        return new int[]{-1,-1};
    }
}
