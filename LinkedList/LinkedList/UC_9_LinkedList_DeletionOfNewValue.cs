﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class UC_9_LinkedList_DeletionOfNewValue
    {
        internal Node head;
        internal string size;
        internal Node DeletionOfNewValue(int data)
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
