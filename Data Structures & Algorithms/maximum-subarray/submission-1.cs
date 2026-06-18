public class Solution {
    public int MaxSubArray(int[] nums) {
        int current = 0;
        int max = nums[0];
        for(int i =0; i<nums.Length; i++){
            if(current<0) {
                current =0;
            }
           
        current +=nums[i];
        max= Math.Max(current, max);
    }
    return max;

}}
