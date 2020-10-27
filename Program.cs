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
            list.Append(30);
            list.Append(70);
            //list.InsertionAtParticularPosition(2, 30);
            list.Display();
        }
    }
}
