public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++) {
            var complement = target - nums[i];

            if (dict.TryGetValue(complement, out int value)) {
                return [value, i];
            }

            dict[nums[i]] = i;
        }

        throw new ArgumentException("No two sum solution");
    }
}
