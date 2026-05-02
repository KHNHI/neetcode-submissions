public class Solution {
    public int MajorityElement(int[] nums) {
      int count =0,  res=0;
      foreach(int num in nums){
        if(count ==0){
            res=num;
        }
        if(num==res){
            count++;
        }
        else {count--;}
      }
      return res;
    }
}