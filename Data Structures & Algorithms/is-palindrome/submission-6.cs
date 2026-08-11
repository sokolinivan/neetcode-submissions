public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;

        while (left <= right)
        {
            var leftChar = char.ToLower(s[left]);
            var rightChar = char.ToLower(s[right]);
            
            if (!char.IsLetterOrDigit(rightChar))
            {
                right--;
                continue;
            }
            
            if (!char.IsLetterOrDigit(leftChar))
            {
                left++;
                continue;
            }

            if (leftChar != rightChar)
            {
                return false;
            }
            
            left++;
            right--;
        }

        return true;
    }
}
