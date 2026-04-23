public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 0){
            return 0;
        }
        if(nums.Length< 2){
            return nums[0];
        }
        int[] max = new int[nums.Length];
        max[0]= nums[0];
        max[1]= Math.Max(nums[0], nums[1]);
        for(int i =2; i<nums.Length; i++){
            max[i]= Math.Max(max[i-2]+nums[i], max[i-1]);
        }
        return max[nums.Length-1];
    }
}
