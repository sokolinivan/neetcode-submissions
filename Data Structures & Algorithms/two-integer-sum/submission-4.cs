public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> buf = new Dictionary<int, int>(nums.Length);

        for (int i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];

            if (!buf.ContainsKey(nums[i])) {
                buf.Add(diff, i);
            } else {
                return new int[] { buf[nums[i]], i};
            }
        }

        return Array.Empty<int>();
    }
}
