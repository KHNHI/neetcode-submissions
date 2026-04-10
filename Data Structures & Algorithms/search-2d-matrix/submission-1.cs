public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix.Length == 0)return false;
        int rows = matrix.Length;
        int columns = matrix[0].Length;
        int left =0;
        int right = rows*columns-1;
        while(left<=right){
            int mid = left+(right-left)/2;
            int midPos= matrix[mid/columns][mid%columns];
            if(midPos==target){
                return true;
            }
            else if(target<midPos){
                right = mid-1;
            }else if(target>midPos){
                left = mid+1;
            }
        }
        return false;
    }
}
