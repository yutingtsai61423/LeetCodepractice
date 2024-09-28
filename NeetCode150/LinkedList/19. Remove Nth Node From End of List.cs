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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        //維持right pointer == Null的時候，left剛好落在倒數的第k個node的前一個
        ListNode dummy = new ListNode(0, head);
        ListNode left = dummy;
        ListNode right = dummy;
        //[dummy,1,2,3,4], n = 2 
        //先讓right 走到 n+1 th個
        int count = n;
        while (count + 1 > 0 && right != null)
        {
            right = right.next;
            count--;
        }

        //開始走 直到right == null;
        while (right != null)
        {
            right = right.next;
            left = left.next;
        }

        //走到底了，修改left的pointer
        left.next = left.next.next;
        return dummy.next;
    }
}
