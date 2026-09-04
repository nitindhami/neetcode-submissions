public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
       Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

       for (int i=0;i<strs.Length;i++)
       {
         char[] chars = strs[i].ToCharArray();
         Array.Sort(chars);
         string key = new string(chars);

         if(!map.ContainsKey(key))
         {
          map[key] = new List<string>();
         }
            map[key].Add(strs[i]);

        }    
     return new List<List<string>>(map.Values);
    }

}