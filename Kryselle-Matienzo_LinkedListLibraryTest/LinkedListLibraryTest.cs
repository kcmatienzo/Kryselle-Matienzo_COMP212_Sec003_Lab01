using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kryselle_Matienzo_LinkedListLibrary;

namespace Kryselle_Matienzo_LinkedListLibraryTest
{
    class LinkedListLibraryTest
    {
        static void Main(string[] args)
        {
            var listInt = new List<int>(); // create List container
            var listDouble = new List<double>();

            int anInteger1 = 111;
            int anInteger2 = 222;
            int anInteger3 = 333;
            int anInteger4 = 444;
            int anInteger5 = 555;


            double aDouble1 = 1111.11;
            double aDouble2 = 2222.22;
            double aDouble3 = 3333.33;
            double aDouble4 = 4444.44;
            double aDouble5 = 5555.55;

            // use List insert methods for listInt  
            listInt.InsertAtFront(anInteger1);
            listInt.InsertAtFront(anInteger2);
            listInt.InsertAtBack(anInteger3);
            listInt.InsertAtBack(anInteger4);
            listInt.InsertAtFront(anInteger5);
            listInt.Display();
            Console.Write($"Printing GetLastNode for listInt: {listInt.GetLastNode()}");
            Console.WriteLine();
            

            // use List insert methods for listDouble       
            listDouble.InsertAtFront(aDouble1);
            listDouble.InsertAtFront(aDouble2);
            listDouble.InsertAtBack(aDouble3);
            listDouble.InsertAtBack(aDouble4);
            listDouble.InsertAtFront(aDouble5);
            listDouble.Display();
            Console.WriteLine($"Printing GetLastNode for listDouble: {listDouble.GetLastNode()}");
            Console.WriteLine();
            Console.WriteLine("Testing minimum method below");
            Console.WriteLine("-----------------------------");
            listInt.Display();
            Console.WriteLine($"Minimum in the listInt is: {listInt.Minimum()}");
            listDouble.Display();
            Console.WriteLine($"Minimum in the listDouble is: {listDouble.Minimum()}");
        } // end Main()
    } // end class
}
