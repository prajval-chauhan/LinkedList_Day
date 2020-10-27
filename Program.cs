using System;

namespace LinkedList_Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");
            LinkedList list = new LinkedList();
            list.InsertAtFront(70);
            list.InsertAtFront(30);
            list.InsertAtFront(56);
            list.Display();
        }
    }
}
