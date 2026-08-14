public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];

        int zeroCount = 0;
        int product = 1;

        foreach (int num in nums)
        {
            if (num == 0)
            {
                zeroCount++;
            }
            else
            {
                product *= num;
            }
        }

        if (zeroCount > 1)
        {
            return result; // все нули
        }

        if (zeroCount == 1)
        {
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 0)
                {
                    result[i] = product;
                    break;
                }
            }

            return result;
        }

        for (int i = 0; i < n; i++)
        {
            nums[i] = product / nums[i];
        }

        return nums;
    }
}
