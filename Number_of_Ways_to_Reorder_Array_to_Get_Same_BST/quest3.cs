public class Solution {
    public int NumOfWays(int[] nums) {
        const int MOD = 1_000_000_007;

        long[][] pascal = new long[nums.Length + 1][];
        for (int i = 0; i <= nums.Length; i++) {
            pascal[i] = new long[i + 1];
            pascal[i][0] = pascal[i][i] = 1;
            for (int j = 1; j < i; j++) {
                pascal[i][j] = (pascal[i - 1][j - 1] + pascal[i - 1][j]) % MOD;
            }
        }

        long CountWays(List<int> nums) {
            if (nums.Count <= 2) return 1;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 1; i < nums.Count; i++) {
                if (nums[i] < nums[0]) left.Add(nums[i]);
                else right.Add(nums[i]);
            }

            long leftWays = CountWays(left) % MOD;
            long rightWays = CountWays(right) % MOD;

            return (pascal[left.Count + right.Count][left.Count] * leftWays % MOD * rightWays % MOD) % MOD;
        }

        return (int)((CountWays(nums.ToList()) - 1 + MOD) % MOD);
    }
}
