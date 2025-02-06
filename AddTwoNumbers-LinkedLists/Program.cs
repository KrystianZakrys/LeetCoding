
public class ListNode
{
     public int val;
     public ListNode next;
     public ListNode(int val = 0, ListNode next = null)
     {
         this.val = val;
         this.next = next;
     }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode current, result = new ListNode();
        int carry = 0;
        current = result;

        while (l1 != null || l2 != null || carry > 0)
        {
            current.next = new ListNode();
            current = current.next;

            //9+9 = 16
            int newValue = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;

            carry = newValue / 10;
            if (carry > 0)
            {
                newValue = newValue % 10;
            }

            l1 = l1?.next;
            l2 = l2?.next;
            current.val = newValue;
        }

        return result.next;
    }
}