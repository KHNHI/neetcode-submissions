public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int minFre = nums.Length / 3;
        HashSet<int> res = new HashSet<int>();
        Dictionary<int,int> numFre = new Dictionary<int,int>();
        foreach(int num in nums){
            if(numFre.ContainsKey(num)){
                numFre[num]++;
            }else{
                numFre[num]=1;
            }
            if(numFre[num] > minFre ){
                res.Add(num);
            }
        }
        // for(int i =0; i<nums.Length; i++){
        //     if(numFre[nums[i]] > minFre){
        //         res.Add(nums[i]);
        //     }
        // }
        return res.ToList();
    }
}