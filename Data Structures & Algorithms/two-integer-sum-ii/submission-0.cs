public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        int low = 0;
        int high = numbers.Length-1;
      
      while(low<high)
      {
        if(numbers[low]+ numbers[high]==target)
          return new int[2] {low+1,high+1};

         if(numbers[low]+numbers[high]>target)
         {
            high--;
         }
         else 
         {
            low++;
         }
      }
       return null;    
    }
}
