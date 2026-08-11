public class Solution {
	public int LongestConsecutive(int[] nums)
	{
		var hash = new HashSet<int>(nums);
		var length = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			var current = nums[i];
			
			if (hash.Contains(current - 1))
				continue;
				
			var temp = 1;

			while (hash.Contains(++current))
			{
				temp++;
			}
			
			length = Math.Max(length, temp);
		}
		
		return length;
	}
}
