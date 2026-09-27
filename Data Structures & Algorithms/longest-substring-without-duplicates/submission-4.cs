public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
      if (s.Length == 0)
        return 0;
      var charArray = s.ToCharArray();
      int maxCount =0;
      int currentCount =0;
       HashSet<Char> con = new HashSet<Char>();
      int left =0;
      int right =0;

   while (right < s.Length)
    {
        while (con.Contains(s[right]))
        {
            con.Remove(s[left]);
            left++;
        }

        con.Add(s[right]);

        maxCount = Math.Max(maxCount, right - left + 1);

        right++;
    }



      
      
      return maxCount;
    }
}
