public class Solution {
    public int[] SortArray(int[] nums) {
       Dictionary<int, int> freq = new Dictionary<int, int>();
       int minVal = int.MaxValue, maxVal = int.MinValue;
       foreach(int num in nums){
        if(freq.ContainsKey(num)){
            freq[num]++;
        }else{
        freq[num]=1;
        }
        minVal= Math.Min(minVal, num);
        maxVal= Math.Max(maxVal, num);
       }
       int index =0;
       for(int val = minVal; val <= maxVal; val++){
        if(!freq.ContainsKey(val)) continue;
        while(freq[val]-- >0){
            nums[index++]=val;
        }
       }
       return nums;
    }
}