public class Solution {
    public string MinWindow(string s, string t) 
    {
        if (string.IsNullOrEmpty(s) ||
            string.IsNullOrEmpty(t) ||
            s.Length < t.Length)
        {
            return "";
        }
        
        // Count required character occurrences.
        Dictionary<char, int> need = new Dictionary<char, int>();
        foreach (char c in t)
        {
            if (!need.ContainsKey(c))
                need[c] = 0;

            need[c]++;
        }
     
        int left = 0;
        int missing = t.Length;

        int minLength = int.MaxValue;
        int start = 0;
        for (int right = 0; right < s.Length; right++)
        {
            char incoming = s[right];

            // Include the new character in the window.
            if (need.ContainsKey(incoming))
            {
                if (need[incoming] > 0)
                    missing--;

                need[incoming]--;
            }

            // When missing == 0, the window is valid.
            while (missing == 0)
            {
                int windowLength = right - left + 1;

                // Save the smallest valid window.
                if (windowLength < minLength)
                {
                    minLength = windowLength;
                    start = left;
                }

                char outgoing = s[left];

                // Remove the leftmost character.
                if (need.ContainsKey(outgoing))
                {
                    need[outgoing]++;

                    // We now need this character again.
                    if (need[outgoing] > 0)
                        missing++;
                }

                left++;
            }
        }

        return minLength == int.MaxValue
            ? ""
            : s.Substring(start, minLength);
    }

    }

