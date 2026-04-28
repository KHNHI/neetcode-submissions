public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] res = new int[n];
        
        Stack<(int temp, int idx)> stack = new Stack<(int temp, int idx)>();

        for (int i = 0; i < n; i++) {
            int currentTemp = temperatures[i];

            while (stack.Count > 0 && currentTemp > stack.Peek().temp) {
                var prev = stack.Pop();
                res[prev.idx] = i - prev.idx;
            }

            stack.Push((currentTemp, i));
        }

        return res;
    }
}