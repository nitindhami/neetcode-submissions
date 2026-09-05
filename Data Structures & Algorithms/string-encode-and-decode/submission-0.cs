public class Solution {

    public string Encode(IList<string> strs) 
    {
     var sb = new StringBuilder();
    
    foreach (var str in strs) 
    {
        sb.Append(str.Length);
        sb.Append('#');
        sb.Append(str);
    }
    
      return sb.ToString();   
    }

    public List<string> Decode(string s) 
    {
        var result = new List<string>();
        int i = 0;

        while (i < s.Length) 
        {
            // Step 1: Find the delimiter '#' starting from i
            int j = s.IndexOf('#', i);

            // Step 2: Parse the length prefix
            string lenStr = s.Substring(i, j - i);
            int.TryParse(lenStr, out int len);

            // Step 3: Extract the string of length `len` starting at j + 1
            string word = s.Substring(j + 1, len);
            result.Add(word);

            // Step 4: Advance pointer i to the start of the next chunk
            i = j + 1 + len;
        }

        return result;
   }
}
