public class Solution {
    public void SortColors(int[] nums) {
        int mid = 0, l = 0, r = nums.Length - 1;

        while (mid <= r) {
            if (nums[mid] == 0) {
                Swap(nums, l, mid);
                l++;
            } else if (nums[mid] == 2) {
                Swap(nums, mid, r);
                r--;
                mid--;
            }
            mid++;
        }
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}