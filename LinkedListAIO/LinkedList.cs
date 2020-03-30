using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAIO
{
    public class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = null;
        }

        #region -- Operator --
        public void insertLast(Node node)
        {

            if (this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        #endregion
    }
}
