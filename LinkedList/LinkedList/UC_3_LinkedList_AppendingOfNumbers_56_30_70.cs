using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class UC_3_LinkedList_AppendingOfNumbers_56_30_70
    {
        internal Node head;

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "");
                temp = temp.next;

            }
        }
}
