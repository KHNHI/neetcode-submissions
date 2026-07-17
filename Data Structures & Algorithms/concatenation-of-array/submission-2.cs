public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[(nums.Length)*2]; 
        for(int i =0; i<n; i++){
            ans[i] = nums[i];
            ans[i+n] = nums[i];
        }
        for(int i = n; i<ans.Length; i++){
            ans[i] = nums[i-n];
        }
        return ans;
    }
}