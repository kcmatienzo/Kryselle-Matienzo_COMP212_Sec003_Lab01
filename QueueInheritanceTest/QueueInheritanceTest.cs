using Kryselle_Matienzo_LinkedListLibrary;
using Kryselle_Matienzo_QueueInheritanceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryselle_Matienzo_QueueInheritanceTest
{
    class QueueInheritanceTest
    {
        static void Main(string[] args)
        {
            // create list container
            QueueInheritanceLibrary<int> intQueue = new QueueInheritanceLibrary<int>();
            QueueInheritanceLibrary<double> doubleQueue = new QueueInheritanceLibrary<double>();

            // create objects to store in the queue
            int intOne = 9;
            int intTwo = 8;
            int intThree = 405;
            int intFour = 6;
            int intFive = 5;
            int intSix = 45;
            int intSeven = 632;
            int intEight = 341;

            double num1 = 999.21;
            double num2 = 123.34;
            double num3 = 405.321;
            double num4 = 622.54;
            double num5 = 5876.43;
            double num6 = 45.4;
            double num7 = 632.32;
            double num8 = 341.1342;

            // use method Enqueue to add items to queue
            intQueue.Enqueue(intOne);
            intQueue.Enqueue(intTwo);
            intQueue.Enqueue(intThree);
            intQueue.Enqueue(intFour);
            intQueue.Enqueue(intFive);
            intQueue.Enqueue(intSix);
            intQueue.Enqueue(intSeven);
            intQueue.Enqueue(intEight);
            intQueue.Display();
            Console.WriteLine($"Printing last int queue: {intQueue.GetLast()}");

            // use method Enqueue to add items to queue
            doubleQueue.Enqueue(num1);
            doubleQueue.Enqueue(num2);
            doubleQueue.Enqueue(num3);
            doubleQueue.Enqueue(num4);
            doubleQueue.Enqueue(num5);
            doubleQueue.Enqueue(num6);
            doubleQueue.Enqueue(num7);
            doubleQueue.Enqueue(num8);
            doubleQueue.Display();
            Console.WriteLine($"Printing last for double queue: {doubleQueue.GetLast()}");
        } // end Main()
    } // end class
}
