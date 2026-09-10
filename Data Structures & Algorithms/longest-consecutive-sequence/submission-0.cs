public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
      if (nums == null || nums.Length == 0) return 0;
      // Step 1: Dump all numbers into a HashSet for O(1) lookups
       HashSet<int> numSet = new HashSet<int>(nums);
       int longestStreak = 0;


     foreach (int num in numSet) {
            // Step 2: Check if this number is the start of a sequence
            if (!numSet.Contains(num - 1)) {
                int currentNum = num;
                int currentStreak = 1;

                // Step 3: Count consecutive numbers upwards
                while (numSet.Contains(currentNum + 1)) {
                    currentNum++;
                    currentStreak++;
                }

                // Step 4: Track the maximum sequence length found
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;


        
  
    } 
}
