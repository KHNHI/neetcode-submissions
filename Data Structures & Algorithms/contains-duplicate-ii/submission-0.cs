public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
     for(int l =0; l<nums.Length; l++){
        for(int r =l+1; r<nums.Length; r++){
            if(nums[l]==nums[r] && (r-l)<=k){
                return true;
            }
        }
     }
    return false;
        
    }
}