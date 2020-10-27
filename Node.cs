using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Day16
{
    class Node
    {
        public int data;   //this stores the data that is passed to the node
        public Node next; //everytime data is added a new node is created so that the data for the next node could be stored in it        
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// and the data provided by the user is stored in the data variable
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(int data)
        {
            this.data = data;
        }
    }
}
