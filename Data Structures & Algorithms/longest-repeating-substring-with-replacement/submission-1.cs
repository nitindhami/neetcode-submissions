public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int[] count = new int[26];

        int left = 0;
        int maxFreq = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            int index = s[right] - 'A';

            count[index]++;

            maxFreq = Math.Max(maxFreq, count[index]);

            int windowLength = right - left + 1;

            if (windowLength - maxFreq > k)
            {
                int leftIndex = s[left] - 'A';
                count[leftIndex]--;
                left++;
            }

            windowLength = right - left + 1;
            maxLength = Math.Max(maxLength, windowLength);
        }

        return maxLength;
    }
}