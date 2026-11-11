public class Solution {
    public int Search(int[] nums, int target) 
    {

    int low=0;
    int high = nums.Length-1;
    int mid = 0;
    int output =-1;

    while(low<=high)
    {
        mid = (low + high)/2;

        if(target == nums[mid])
        {
            output = mid;
            break;
        }
        if(target < nums[mid])
        {
           high = mid-1;

        }
        else
        {
          low = mid+1;
        }


    }

    return output;   
   }

}
