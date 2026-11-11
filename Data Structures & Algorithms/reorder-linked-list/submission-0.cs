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
 [1, 2, 3, 4, 5, 6]
 [1, 6, 2, 5, 3, 4]
 */

public class Solution {
    public void ReorderList(ListNode head) {
        Dictionary<int, ListNode> map = new Dictionary<int, ListNode>();

        ListNode temp = head;
        int index = 1;

        while(temp != null){
            map[index] = temp;
            index++;
            temp = temp.next;
        }

        int left = 1;
        int right = index - 1;

        while(left < right){
            ListNode first = map[left];
            ListNode last = map[right];

            first.next = last;

            left++;

            if(left == right){
                last.next = null;
                break;
            }
            last.next = map[left];
            right--;
        }
        map[left].next = null;
    }
}
