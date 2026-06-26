public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numNotDup = new HashSet<int>(nums);
        int longest =0;
        foreach(int num in nums){
            if(!numNotDup.Contains(num-1)){
                int length =1;
                while(numNotDup.Contains(num+length)){
                    length++;
                }
                longest= Math.Max(longest,length);
            }
        }
        return longest;
    }
}
