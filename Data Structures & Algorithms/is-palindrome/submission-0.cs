public class Solution {
    public bool IsPalindrome(string s) 
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            // 1. Skip non-alphanumeric characters on the left
            if (!char.IsLetterOrDigit(s[left])) {
                left++;
                continue;
            }

            // 2. Skip non-alphanumeric characters on the right
            if (!char.IsLetterOrDigit(s[right])) {
                right--;
                continue;
            }

            // 3. Both are valid: compare them case-insensitively
            if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                return false; // Mismatch found
            }

            // 4. Characters match; move both pointers inward
            left++;
            right--;
        }

        return true; 
        
    
    }
}
