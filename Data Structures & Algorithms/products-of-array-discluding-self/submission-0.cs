public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var length = nums.Length;
        int[] result = new int[length];
        Array.Fill(result, 1);

        var prefix = 1;
        var suffix = 1;

        for (int i = 0; i < length; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }

        for (int i = length - 1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }

        return result;
    }
}
