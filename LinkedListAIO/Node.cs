using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAIO
{
    public class Node
    {
        public int data = 0;
        public Node next;

        public Node(int values)
        {
            this.data = values;
            this.next = null;
        }
    }
}
