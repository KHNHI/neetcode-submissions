public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit =0;
        int left= 0, right = 1;
        while(right<prices.Length){
            if(prices[left]<prices[right]) {
            int profit = prices[right] - prices[left];
            maxProfit = Math.Max(maxProfit, profit);
            }
            else {
             left=right;
            }
            right++;
        }
        return maxProfit;
    }
}
