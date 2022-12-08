using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class UC_6_LinkedList_DeletionOfLastElement
    {
        internal Node head;
        internal Node DeletionOfLastElement()
        {
            if (head == null)

                return null;
            if (head.next == null)
                return null;
            Node newnode = head;
            while (newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            newnode.next = head;
            return head;
        }
}
