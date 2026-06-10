public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = [];
        foreach (var n in nums) freq[n] = freq.GetValueOrDefault(n) + 1;

        var keys = new int[freq.Count];
        freq.Keys.CopyTo(keys, 0);
        Array.Sort(keys, (a, b) => freq[b] - freq[a]);

        var result = new int[k];
        for (var i = 0; i < k; i++) result[i] = keys[i];

        return result;
    }
}
