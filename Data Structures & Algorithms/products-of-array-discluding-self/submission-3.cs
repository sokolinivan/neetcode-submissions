public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;

        int[] prefix = new int[n];
        int[] result = new int[n];
        int[] suffix = new int[n];

        prefix[0] = nums[0];
        suffix[n - 1] = nums[n - 1];

        for (int i = 1; i < n; i++)
            prefix[i] = prefix[i - 1] * nums[i];

        for (int i = n - 1; i > 0; i--)
        {
            suffix[i - 1] = suffix[i] * nums[i - 1];
        }

        result[0] = suffix[1];
        result[n - 1] = prefix[n - 2];

        for (int i = 1; i < n - 1; i++)
        {
            result[i] = prefix[i - 1] * suffix[i + 1];
        }

        return result;
    }
}
