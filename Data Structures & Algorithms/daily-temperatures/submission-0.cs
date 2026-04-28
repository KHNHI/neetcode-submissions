public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];
        Stack<int> indices = new Stack<int>();

        // Iterating backwards from the last day to the first
        for(int i = temperatures.Length - 1; i >= 0; i--) {
            
            // 1. Pop elements that are colder than or equal to current temperature
            // Use indices.Count > 0 instead of != null
            while(indices.Count > 0 && temperatures[i] >= temperatures[indices.Peek()]) {
                indices.Pop();
            }
            
            // 2. If stack is NOT empty, the top element is the next warmer day
            if(indices.Count > 0) {
                res[i] = indices.Peek() - i;
            } else {
                res[i] = 0; // No warmer day found in the future
            }
            
            // 3. Push current day's index onto the stack
            indices.Push(i);
        }
        return res;
    }
}