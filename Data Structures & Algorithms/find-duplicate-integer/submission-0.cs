public class Solution {
    public int FindDuplicate(int[] nums) {
        // int maxDup =0;
        // Dictionary<int,int> count = new Dictionary<int,int>();
        // for(int i=0; i<nums.Length; i++){
        //     if(count.ContainsKey(nums[i])){
        //         count[nums[i]]++;
        //     }else{
        //         count[nums[i]]=1;
        //     }
        //     if(count[nums[i]>maxDup]{
        //         maxDup=count[nums[i]];

        //     })
        //     maxDup= Math.Max(maxDup, count[nums[i]]);
            
        // }
        // return maxDup;
        HashSet<int> maxDup = new HashSet<int>();
        for (int i=0; i<nums.Length; i++){
            if(maxDup.Contains(nums[i])){
                return nums[i];
            }
            maxDup.Add(nums[i]);
        }
        return 0;

    }
}
