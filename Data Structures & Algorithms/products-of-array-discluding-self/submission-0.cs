public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
    int n = nums.Length;
    int[] output = new int[n];

    // First pass: store product of everything to the LEFT
    int prefix = 1;

    for (int i = 0; i < n; i++)
    {
        output[i] = prefix;
        prefix *= nums[i];
    }

    // Second pass: multiply by product of everything to the RIGHT
    int suffix = 1;

    for (int i = n - 1; i >= 0; i--)
    {
        output[i] *= suffix;
        suffix *= nums[i];
    }

    return output;    
    }
}
