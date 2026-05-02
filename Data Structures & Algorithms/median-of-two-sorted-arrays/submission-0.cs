public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] smaller = nums1.Length > nums2.Length? nums2: nums1;
        int[] larger = nums1.Length > nums2.Length? nums1: nums2;
        int totalLength = nums1.Length+nums2.Length;
        int low =0, high = smaller.Length;
        while(low<=high){
            int partitionX= (low+high)/2;
            int partitionY=(totalLength+1)/2 - partitionX;

            int l1= partitionX==0? int.MinValue : smaller[partitionX-1];
            int r1= partitionX==smaller.Length? int.MaxValue : smaller[partitionX];
            
            int l2= partitionY==0? int.MinValue : larger[partitionY-1];
            int r2= partitionY==larger.Length? int.MaxValue : larger[partitionY];

            if(l1<=r2 && l2<=r1){
                if(totalLength % 2==0){
                 return (Math.Max(l1, l2) + Math.Min(r1, r2)) / 2.0;          
                }else{
                 return Math.Max(l1,l2);
                }
            }
            if(l1>r2) high = partitionX -1;
            else low = partitionX +1;
        
            }
            return 0;
        }

    }

