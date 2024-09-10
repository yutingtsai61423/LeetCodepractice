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
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        ListNode tmp = null;
        while (curr != null)
        {
            Console.WriteLine($"cur = {curr.val}");
            tmp = curr.next;//舊指向
            curr.next = prev;//改指向
            int printVal = curr.next == null ?  0 :curr.next.val;
            Console.WriteLine($"cur new next = {printVal}");
            //換點
            prev = curr;
            curr = tmp;
            Console.WriteLine("------");
        }
        return prev;
    }
}
