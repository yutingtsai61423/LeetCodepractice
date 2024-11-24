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
    public ListNode reverseList(ListNode head) {
	        if (head == null) {
	        	return null;
	        } else if (head.next == null) {
	        	return head;
	        }
	    	ListNode nextnode =new ListNode();
	    	ListNode temp = new ListNode();
	    	ListNode foretemp = new ListNode();
	    	//取出下一個
	    	temp = head.next;
	    	//改自己的指向
	    	head.next = null;
       
	        foretemp = head;
	        
	        while(temp.next != null) {
	    		//取出下一個
		        nextnode = temp.next;
	    		//更改我的指向
	    		temp.next = foretemp;

	    		//把我變成下一回合的上一個
	    		foretemp = temp;
	    		//取出的下一個，變成下一回合的主角
	    		temp = nextnode;
	        }
    		
	        temp.next = foretemp;
	    	return temp;
    }
}
