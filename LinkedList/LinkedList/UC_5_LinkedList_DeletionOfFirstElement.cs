using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class UC_5_LinkedList_DeletionOfFirstElement
    {
        internal Node head;
        internal Node DeletionOfFirstElement()
        {
            if (this.head == null)
                return null;
            this.head = head.next;
            return this.head;
        }
    }
}
