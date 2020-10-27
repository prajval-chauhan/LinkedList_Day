using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Day16
{
    class LinkedList
    {
        internal Node head;
        /// <summary>
        /// Adds the specified data into the node. Also assigns the 
        /// head node and create a next pointer which points to the next node
        /// This method add to the rear end of the list so it is basically 
        /// performing the append operation
        /// </summary>
        /// <param name="data">The data.</param>
        internal void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data+" is inserted into the linked list");
        }
        /// <summary>
        /// Displays the contents of the linked list
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        /// <summary>
        /// This method inserts the node to the front of the list
        /// Makes the next pointer of the node point to the head pointer
        /// and then makes the head pointer point to the new node
        /// </summary>
        /// <param name="data">The data.</param>
        internal void InsertAtFront(int data)
        {
            Node node = new Node(data);
            node.next = this.head;
            this.head = node;
        }
    }
}
