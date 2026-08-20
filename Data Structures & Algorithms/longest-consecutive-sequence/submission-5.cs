public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 1) {
            return 1;
        }
        HashSet<int> set = new HashSet<int>(nums);
        var max = 0;

        foreach(var num in set) {
            if(!set.Contains(num-1)) { //Начало последовательности
                var sequence = 1;
                while(set.Contains(num+sequence)) {
                    sequence++;
                }
                max = Math.Max(sequence, max);
            }
        };

        return max;
    }
}
