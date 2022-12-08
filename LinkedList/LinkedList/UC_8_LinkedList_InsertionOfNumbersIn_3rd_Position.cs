using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class UC_8_LinkedList_InsertionOfNumbersIn_3rd_Position
    {

        internal Node head;
        internal Node InsertionOfValue(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("The LinkedList is empty");

            }
            if (position == 1)
            {
                var newnode = new Node(data);
                newnode.next = this.head;
                this.head = newnode;

            }
            else
            {
                Node temp = this.head;
                while (position-- != 0)
                {
                    if (position == 1)
                    {

                        Node node = new Node(data);
                        node.next = this.head.next;
                        this.head = node;
                    }
                    break;

                }

            }
            if (position != 1)
            {
                Console.WriteLine("The position is out of range");
            }
            return head;
        }
    }
}
