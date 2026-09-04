public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        // 1. Count frequencies 📊
        var map = new Dictionary<int, int>();
        foreach (int num in nums) {
            map[num] = map.GetValueOrDefault(num, 0) + 1;
        }

        // 2. Setup buckets 🪣
        var buckets = new List<int>[nums.Length + 1];
        foreach (var pair in map) {
            int num = pair.Key;
            int freq = pair.Value;
            if (buckets[freq] == null) {
                buckets[freq] = new List<int>();
            }
            buckets[freq].Add(num);
        }

        // 3. Gather top k from highest frequency down 📤
        int[] topK = new int[k];
        int i = 0;

        for (int freq = buckets.Length - 1; freq >= 1; freq--) {
            if (buckets[freq] != null) {
                foreach (int val in buckets[freq]) {
                    topK[i] = val;
                    i++;
                    if (i == k) {
                        return topK;
                    }
                }
            }
        }

        return topK;
}
}
