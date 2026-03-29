public class Solution {
    public int MaxArea(int[] heights) {
        int left =0, right = heights.Length-1;
        int maxWater =0;
        while (left<right){
            int waterContain= Math.Min(heights[left],heights[right])*(right-left);
            maxWater = Math.Max(maxWater, waterContain);
            if(heights[left]<= heights[right]){
            left++;
            }else
            {right--;
            }
        }
        return maxWater;
    }
}
