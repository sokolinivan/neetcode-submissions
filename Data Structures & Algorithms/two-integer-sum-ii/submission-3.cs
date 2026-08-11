public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum > target)
            {
                right--;
                continue;
            }

            if (sum < target)
            {
                left++;
                continue;
            }

            left++;
            right++;

            return new int[] { left, right };
        }

        return Array.Empty<int>();
    }
}
