public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        List<int> res = new List<int>();
        int colBegin = 0, colEnd = matrix[0].Length;
        int rowBegin = 0, rowEnd = matrix.Length;

        while (colBegin < colEnd && rowBegin < rowEnd) {
            for (int i = colBegin; i < colEnd; i++) {
                res.Add(matrix[rowBegin][i]);
            }
            rowBegin++;
            for (int i = rowBegin; i < rowEnd; i++) {
                res.Add(matrix[i][colEnd - 1]);
            }
            colEnd--;
            if (!(colBegin < colEnd && rowBegin < rowEnd)) {
                break;
            }
            for (int i = colEnd - 1; i >= colBegin; i--) {
                res.Add(matrix[rowEnd - 1][i]);
            }
            rowEnd--;
            for (int i = rowEnd - 1; i >= rowBegin; i--) {
                res.Add(matrix[i][colBegin]);
            }
            colBegin++;
        }

        return res;
    }
}