using System;

namespace LinkedList_Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(70);
            list.InsertionAtParticularPosition(2, 30);
            Console.WriteLine("\nThe node number of 30 is {0}", list.SearchNode(30));
            list.DeleteNode(30);
            list.Display();
            //list.DeleteFrontNode();
            //list.DeleteLastNode();
        }
    }
}
