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
    public ListNode AddTwoNumbers(ListNode l1, ListNode? l2)
    {
        //dummy要留著 不然走到 end 會沒辦法拿回dummy
        ListNode dummy = new ListNode();
        //創造一個結果list
        ListNode cur = dummy;

        //把位數相加 後續直接借用l1 l2這兩個變數 不用再多宣告
        int carry = 0;
        while (l1 != null || l2 != null || carry > 0)
        {
            //把值相加 若是null則補0
            int l1Val = l1 == null ? 0 : l1.val; 
            int l2Val = l2 == null ? 0 : l2.val; 

            int sum = l1Val + l2Val + carry; 

            //取個位數 
            int digit = sum % 10; 
            cur.next = new ListNode(digit);

            //十位數放carry 給下一回合加
            carry = sum / 10; //1

            l1 = l1?.next;
            l2 = l2?.next;
            cur = cur.next;

        }

        return dummy.next;
    }
}
