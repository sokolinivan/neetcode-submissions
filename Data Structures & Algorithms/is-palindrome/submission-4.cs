public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrWhiteSpace(s) || s.Length == 1) {
            return true;
        }

        var left = 0;
        var right = s.Length - 1;

        while(left < right) {
			if(!char.IsAsciiLetter(s[left]) && !char.IsDigit(s[left]))
			{
				left++;
				continue;
			}

			if (!char.IsAsciiLetter(s[right]) && !char.IsDigit(s[right]))
			{
				right--;
				continue;
			}

            if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right])) {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
