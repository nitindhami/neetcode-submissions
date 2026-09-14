public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
         Array.Sort(nums);

    var result = new List<List<int>>();

    for (int i = 0; i < nums.Length - 2; i++)
    {
        // Skip duplicate starting values
        if (i > 0 && nums[i] == nums[i - 1])
            continue;

        int low = i + 1;
        int high = nums.Length - 1;

        while (low < high)
        {
            int sum = nums[i] + nums[low] + nums[high];

            if (sum == 0)
            {
                result.Add(new List<int>
                {
                    nums[i],
                    nums[low],
                    nums[high]
                });

                low++;
                high--;

                // Skip duplicate left values
                while (low < high && nums[low] == nums[low - 1])
                    low++;

                // Skip duplicate right values
                while (low < high && nums[high] == nums[high + 1])
                    high--;
            }
            else if (sum < 0)
            {
                low++;
            }
            else
            {
                high--;
            }
        }
    }

    return result;
        
    }
}
