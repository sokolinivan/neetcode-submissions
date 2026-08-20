public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;

        while (left < right) {
            if (!char.IsLetterOrDigit(s[left])) {
                left++;
                continue;
            }

            if(!char.IsLetterOrDigit(s[right])) {
                right--;
                continue;
            }

            if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right])) {
                Console.WriteLine($"l = {left} =  {s[left]}; r = {right} = {s[right]}");
                return false;
            }

            left++; right--;
        }

        return true;
    }
}
