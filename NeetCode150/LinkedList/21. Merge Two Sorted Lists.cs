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
   public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        //創dummy head
        //比較兩個list的node，值比較小的放入答案隊伍中
        //最後若有一個List結束，另一個list可以整段接到答案隊伍中
        ListNode dummy = new ListNode();
        ListNode tail = dummy; //讓dummy當第0個頭

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }

            tail = tail.next;
        }

        //當有一個list結束 把整段接到tail上面
        if (list1 != null) tail.next = list1;
        else if (list2 != null) tail.next = list2;

        return dummy.next;
    }
}
