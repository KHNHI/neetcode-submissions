public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> maxDup = new HashSet<int>();
        for (int i=0; i<nums.Length; i++){
            if(maxDup.Contains(nums[i])){
                return nums[i];
            }
            maxDup.Add(nums[i]);
        }
        return -1;

    }
}
