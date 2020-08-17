using System;
using Kryselle_Matienzo_LinkedListLibrary;

namespace Kryselle_Matienzo_QueueInheritanceLibrary
{
    public class QueueInheritanceLibrary<T> : List<T> where T : IComparable<T>
    {
        // pass name "queue" to List constructor
        public QueueInheritanceLibrary() : base("queue") { }

        // place dataValue at end of queue by inserting 
        // dataValue at end of linked list
        public void Enqueue(T dataValue)
        {
            InsertAtBack(dataValue);
        }

        // remove item from front of queue by removing
        // item at front of linked list
        public T Dequeue()
        {
            return RemoveFromFront();
        }

        public T GetLast()
        {
            //return the last element in the queue and not delete it
            return GetLastNode();
        }
    }
}
