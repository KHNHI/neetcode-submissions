public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int curSum=0, res=0;
        Dictionary<int,int> prefixSum = new Dictionary<int,int>();
        prefixSum[0]=1;
        foreach(int num in nums){
            curSum+=num;
            int diff = curSum -k;
            if(prefixSum.ContainsKey(diff)){
                res+= prefixSum[diff];
            }
            if(!prefixSum.ContainsKey(curSum)){
                prefixSum[curSum]=0;
            }
            prefixSum[curSum]++;
        }
        return res;
    }
}