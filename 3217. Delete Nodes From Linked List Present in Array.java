/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode modifiedList(int[] nums, ListNode head) {
        //統一放數字
        Set<Integer> set = new HashSet<>();
        for (int num :  nums) {
            set.add(num);
        }
        //
        
        ListNode dummyHead = new ListNode(0, head);
        ListNode nodeCur = dummyHead;
        
        while (nodeCur.next != null){
            //要刪掉
            if( set.contains(nodeCur.next.val)) {
                  nodeCur.next = nodeCur.next.next; //接下一個
            } else {
                nodeCur = nodeCur.next;
            }
        }
        
        
        return dummyHead.next;
    }
}
