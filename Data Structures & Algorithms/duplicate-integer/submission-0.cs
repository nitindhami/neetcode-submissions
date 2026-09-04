public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
      Dictionary<int, int> map = new Dictionary<int,int>();

      for(int i=0;i<nums.Length;i++)
      {
          if(map.ContainsKey(nums[i]))
           return true;
        else
           {
            map.Add(nums[i],0);
           }
      }
      return false;     
    }
}