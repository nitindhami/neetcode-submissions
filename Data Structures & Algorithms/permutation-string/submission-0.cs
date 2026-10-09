public class Solution {
    public bool CheckInclusion(string s1, string s2) 
    {
      if(s1.Length>s2.Length)
       return false ;

        int[] s1Count = new int[26];
        int[] windowCount = new int[26];

        // Build the target frequency and initial window frequency
        for (int i = 0; i < s1.Length; i++)
        {
            s1Count[s1[i] - 'a']++;
            windowCount[s2[i] - 'a']++;
        }
            if (s1Count.SequenceEqual(windowCount))
            return true;

        for (int right = s1.Length; right < s2.Length; right++)
        {
            int incoming = s2[right] - 'a';
            int outgoing = s2[right - s1.Length] - 'a';

            windowCount[incoming]++;
            windowCount[outgoing]--;

            if (s1Count.SequenceEqual(windowCount))
                return true;
        }    
        return  false;
    }
}
