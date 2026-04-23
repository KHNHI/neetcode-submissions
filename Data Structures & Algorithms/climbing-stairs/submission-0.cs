public class Solution {
    public int ClimbStairs(int n) {    
        if (n <= 2) {
            return n;
        } 
        int[] store = new int[n+1];
        store[1]=1;
        store[2]=2;
        for(int i=3; i<= n; i++){
            store[i]=  store[i-1] + store[i-2];
        }
        return store[n];
    }
}
