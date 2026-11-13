public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        List<int> values = new List<int>();

        foreach (ListNode head in lists) {
            ListNode current = head;
            while (current != null) {
                values.Add(current.val);
                current = current.next;
            }
        }

        values.Sort();

        ListNode dummy = new ListNode();
        ListNode tail = dummy;

        foreach (int v in values) {
            tail.next = new ListNode(v);
            tail = tail.next;
        }

        return dummy.next;
    }
}
