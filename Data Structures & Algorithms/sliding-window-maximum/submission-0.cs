
public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int n = nums.Length;

        // Stores maximum for each window
        int[] result = new int[n - k + 1];

        // Stores indices of useful candidates
        LinkedList<int> deque = new LinkedList<int>();

        for (int right = 0; right < n; right++)
        {
            // STEP 1: Remove expired indices
            while (deque.Count > 0 &&
                   deque.First.Value <= right - k)
            {
                deque.RemoveFirst();
            }

            // STEP 2: Remove smaller elements from back
            while (deque.Count > 0 &&
                   nums[deque.Last.Value] <= nums[right])
            {
                deque.RemoveLast();
            }

            // STEP 3: Add current index
            deque.AddLast(right);

            // STEP 4: Store maximum if window is complete
            if (right >= k - 1)
            {
                result[right - k + 1] =
                    nums[deque.First.Value];
            }
        }

        return result;
    }
}
