public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int newLength = nums.Length*2;
        int[] ans = new int[newLength];
        for(int i =0; i< newLength; i++ ){
            if(i< nums.Length){
               ans[i]= nums[i];
            }else{
                ans[i]=nums[i-nums.Length];
               }
        }
        return ans;
    }
}