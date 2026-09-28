public class Solution {
    public int CharacterReplacement(string s, int k) 
    {
    int[] count = new int[26];

    int left = 0;
    int maxFrequency = 0;
    int answer = 0;

    for (int right = 0; right < s.Length; right++)
    {
        // Add current character
        int index = s[right] - 'A';
        count[index]++;

        // Update the highest frequency in the window
        maxFrequency = Math.Max(maxFrequency, count[index]);

        // If too many replacements are required,
        // shrink the window from the left
        while ((right - left + 1) - maxFrequency > k)
        {
            count[s[left] - 'A']--;
            left++;
        }

        // Current window is valid
        answer = Math.Max(answer, right - left + 1);
    }

    return answer;

         
    }
}
