using System;
using System.Transactions;
using Inhertiance;

namespace Concepts;



//   Definition for singly-linked list.
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
    public static void Run()
    {
        ListNode l1 = new ListNode(9, null);
        ListNode l2 = new ListNode(9, l1);
        ListNode l3 = new ListNode(9, l2);
        ListNode l4 = new ListNode(9, l3);
        ListNode l5 = new ListNode(9, l4);
        ListNode l6 = new ListNode(9, l5);
        ListNode l7 = new ListNode(9, l6);
        // Console.WriteLine($"the value of l is {l3.val} -> {l2.val} -> {l1.val}");
        ListNode current = l7;
        while (current != null)
        {
            Console.Write($"{current.val} -> ");
            current = current.next;
        }
        Console.WriteLine();
        ListNode m1 = new ListNode(9, null);
        ListNode m2 = new ListNode(9, m1);
        ListNode m3 = new ListNode(9, m2);
        ListNode current2 = m3;

        while (current2 != null)
        {
            Console.Write($"{current2.val} -> ");
            current2 = current2.next;
        }
        // Console.WriteLine($"the value of m is {m3.val} -> {m2.val} -> {m1.val}");

        ListNode n1 = l1;
        ListNode n2 = m1;
        ListNode n3 = new ListNode();
        bool carry = false;

        while (n1 != null && n2 != null)
        {
            if (n3.next == null)
            {
                int sum = n1.val + n2.val;
                if (sum >= 10)
                {
                    carry = true;
                    sum -= 10;
                }
                ListNode n5 = new ListNode(sum);
                n3.next = n5;
            }
            else
            {
                int sum = carry ? n1.val + n2.val + 1 : n1.val + n2.val;
                if (sum >= 10)
                {
                    carry = true;
                    sum -= 10;
                }
                else
                {
                    carry = false;
                }
                ListNode n4 = new ListNode(sum, n3);
                n3.next = n4;
            }


            Console.Write($"{n3.next.val} -> ");

            n1 = n1.next;
            n2 = n2.next;
            // break;   
        }
        Console.WriteLine();

    }
    // public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    // {
    //     ListNode l3 = new ListNode();
    //     Console.WriteLine(l1.next.next.next.val);
    //     int current = l1.val;
    //     ListNode next = l1;
    //     while (next.next != null)
    //     {
    //         next = l1.next;
    //         current = next.val;
    //         Console.WriteLine($"val is - {current}");
    //     }
    //     return l1;
    // }

}