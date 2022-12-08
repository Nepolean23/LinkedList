using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class UC_2_LinkedList_AddingOFNumber_56_30_70
    {
        public Node head;
        public void AddingNumbers(int data)
        {
            Node Node = new Node(data);
            if (this.head == null)
                this.head = Node;
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = Node;
            }

            Console.WriteLine("{0} The value added in LinkedList", Node.data);


        }
    }
