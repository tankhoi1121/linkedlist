using System;

namespace LinkedListAIO
{
    class Program
    {
        static void PrintLinkedList(LinkedList list)
        {
            var temp = list.head;
            while (temp != null)
            {
                Console.WriteLine("{0}, ", temp.data);
                temp = temp.next;
            }
        }
        static void Main(string[] args)
        {
            Node node = new Node(44);
            Node node1 = new Node(21);

            LinkedList linkedList = new LinkedList();

            linkedList.insertLast(node);
            //linkedList.insertLast(node1);

            PrintLinkedList(linkedList);

            Console.ReadKey();
        }
    }
}
