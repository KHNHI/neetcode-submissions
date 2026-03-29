/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists ) {
        if(lists.Length==0) return null;
       ListNode res = null;
      foreach (ListNode list in lists){
        res= Merge2Lists(res, list);
      }
      return res;
    }
    
    public ListNode Merge2Lists(ListNode list1, ListNode list2) {
          ListNode dummy = new ListNode(0);
        ListNode tail = dummy;
        while(list1 != null && list2 != null){
            if(list1.val <= list2.val){
                tail.next = list1;
                list1 = list1.next;
            }else{
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }
        if(list1!=null){
            tail.next=list1;
        }else{
        tail.next=list2;
        }
        
        return dummy.next;
    }

}
