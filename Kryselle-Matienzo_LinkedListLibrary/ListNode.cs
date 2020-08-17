using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryselle_Matienzo_LinkedListLibrary
{
    // A class to represent one node in a list
    public class ListNode<T>
    {
        // automatic read-only property Data
        //public object Data { get; private set; }
        public T Data { get; private set; }

        // automatic property Next
        public ListNode<T> Next { get; set; } // reference to the next node of the same type

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        // public ListNode(object dataValue) : this(dataValue, null) { }
        public ListNode(T dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that rewe didn fers to dataValue
        // and refers to next ListNode in List
        // public ListNode(object dataValue, ListNode nextNode)
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
}
