using System;

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

public class LinkedListEx
{
    public static void Run()
    {
        // ListNode l1 = new ListNode(3);
        ListNode l2 = new ListNode(9);
        ListNode l3 = new ListNode(9, l2);

        // ListNode m1 = new ListNode(4);
        // ListNode m2 = new ListNode(6, m1);
        ListNode m3 = new ListNode(9);

        // while(l3 != null)   
        // {
        //     System.Console.Write($"{l3.val} -> ");
        //     l3 = l3.next;
        // }
        // Console.WriteLine();
        //  while(m3 != null)   
        // {
        //     System.Console.Write($"{m3.val} -> ");
        //     m3 = m3.next;
        // }
        ListNode n1 = null;
        ListNode n2 = null;
        bool carry = false;
        while (l3 != null || m3 != null)
        {
            int a = 0;
            if (l3 != null)
            {
                a = l3.val;
            }
            int b = 0;
            if (m3 != null)
            {
                b = m3.val;
            }
            int c;
            System.Console.WriteLine($"a is {a} and b is {b} and sum is {a + b}");

            if (carry)
            {
                if (a + b + 1 > 9)
                {
                    carry = true;
                    c = (a + b + 1) - 10;
                }
                else
                {
                    carry = false;
                    c = a + b + 1;
                }
            }
            else
            {
                if (a + b > 9)
                {
                    carry = true;
                    c = (a + b) - 10;
                }
                else
                {
                    carry = false;
                    c = a + b;
                }
            }



            if (n1 == null)
            {
                ListNode local = new ListNode(c);
                n1 = local;
                n2 = local;
            }
            else
            {
                ListNode local = new ListNode(c);
                n1.next = local;
                n1 = n1.next;
            }

            System.Console.WriteLine($"value of c is {c}");
            if (l3 != null)
            {
                l3 = l3.next;
            }

            if (m3 != null)
            {
                m3 = m3.next;
            }

        }
        if (carry)
        {
            ListNode local = new ListNode(1);
            n1.next = local;
            n1 = n1.next;
        }
        // ListNode f = new ListNode();
        while (n2 != null)
        {
            System.Console.Write($"{n2.val} -> ");
            n2 = n2.next;
        }
    }
}